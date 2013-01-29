﻿using System;
using System.Collections.Generic;
using System.Linq;

using BetterCms.Core.Models;
using BetterCms.Core.Mvc.Commands;
using BetterCms.Module.Pages.ViewModels.History;
using BetterCms.Module.Root.Mvc;
using BetterCms.Module.Root.Mvc.Grids.Extensions;

using NHibernate.Linq;

namespace BetterCms.Module.Pages.Command.History.GetContentHistory
{
    /// <summary>
    /// Command to load a list of the content history versions.
    /// </summary>
    public class GetContentHistoryCommand : CommandBase, ICommand<GetContentHistoryRequest, ContentHistoryViewModel>
    {
        /// <summary>
        /// Executes the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public ContentHistoryViewModel Execute(GetContentHistoryRequest request)
        {
            var searchQuery = (request.SearchQuery ?? string.Empty).ToLower();

            var history = new List<ContentHistoryItem>();
            request.SetDefaultSortingOptions("CreatedOn", true);

            var contentFutureQuery = Repository
                .AsQueryable<Root.Models.Content>()
                .Where(f => f.Id == request.ContentId && !f.IsDeleted)
                .Where(f => f.Status == ContentStatus.Published || f.Status == ContentStatus.Draft || f.Status == ContentStatus.Archived)
                .FetchMany(f => f.History)
                .ToFuture();

            var content = contentFutureQuery.ToList().FirstOrDefault();

            if (content != null)
            {
                if (content.Status == ContentStatus.Published && ContainsSearchQuery(content, searchQuery))
                {
                    history.Add(Convert(content));
                }

                history.AddRange(content.History.Where(c => IsValidHistoricalContent(c) && ContainsSearchQuery(c, searchQuery)).Select(Convert));     
            }

            history = history.AsQueryable().AddSortingAndPaging(request).ToList();

            return new ContentHistoryViewModel(history, request, history.Count, request.ContentId);
        }

        private bool IsValidHistoricalContent(IHistorical f)
        {
            return !f.IsDeleted && (f.Status == ContentStatus.Published || f.Status == ContentStatus.Draft || f.Status == ContentStatus.Archived);
        }

        private bool ContainsSearchQuery(IHistorical f, string searchQuery)
        {
            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                return f.PublishedByUser.ToLower().Contains(searchQuery) || f.CreatedByUser.ToLower().Contains(searchQuery);
            }
            return true;
        }

        private ContentHistoryItem Convert(IHistorical content)
        {
            return new ContentHistoryItem
                       {
                           Id = content.Id,
                           Version = content.Version,                           
                           Status = content.Status,
                           ArchivedByUser = content.Status == ContentStatus.Archived ? content.CreatedByUser : null,
                           ArchivedOn = content.Status == ContentStatus.Archived ? content.CreatedOn : (DateTime?)null,
                           DisplayedFor = content.Status == ContentStatus.Archived && content.PublishedOn != null
                                   ? content.CreatedOn - content.PublishedOn.Value
                                   : (TimeSpan?)null,
                           PublishedByUser = content.Status == ContentStatus.Published ? content.PublishedByUser : null,
                           PublishedOn = content.Status == ContentStatus.Published ? content.PublishedOn : null,
                           CreatedByUser = content.CreatedByUser,
                           CreatedOn = content.CreatedOn
                       };
        }        
    }
}