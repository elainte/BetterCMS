﻿using System;
using System.Collections.Generic;
using System.Linq;

using BetterCms.Core.DataAccess;
using BetterCms.Core.DataAccess.DataContext;
using BetterCms.Module.Pages.Command.Content.GetPageContentOptions;
using BetterCms.Module.Root.Models;

using NUnit.Framework;

namespace BetterCms.Test.Module.Pages.CommandTests.ContentTests
{
    [TestFixture]
    public class GetPageContentOptionsTest : DatabaseTestBase
    {
        [Test]
        public void Should_Return_Page_Content_Options_Successfully()
        {
            RunActionInTransaction(session =>
            {
                // Create content and options
                var content = TestDataProvider.CreateNewContent();
                var option1 = TestDataProvider.CreateNewContentOption(content);
                var option2 = TestDataProvider.CreateNewContentOption(content);
                var option3 = TestDataProvider.CreateNewContentOption(content);

                content.ContentOptions = new List<ContentOption>();
                content.ContentOptions.Add(option1);
                content.ContentOptions.Add(option2);
                content.ContentOptions.Add(option3);

                var pageContent = TestDataProvider.CreateNewPageContent(content);
                var po1 = TestDataProvider.CreateNewPageContentOption(pageContent);
                po1.Key = option1.Key;
                var po2 = TestDataProvider.CreateNewPageContentOption(pageContent);
                po2.Key = option2.Key;
                var po3 = TestDataProvider.CreateNewPageContentOption(pageContent);
                po3.Key = Guid.NewGuid().ToString();

                pageContent.Options = new List<PageContentOption>();
                pageContent.Options.Add(po1);
                pageContent.Options.Add(po2);
                pageContent.Options.Add(po3);

                session.SaveOrUpdate(pageContent);
                session.Flush();
                session.Clear();

                // Create command
                var unitOfWork = new DefaultUnitOfWork(session);
                var command = new GetPageContentOptionsCommand();
                command.UnitOfWork = unitOfWork;
                command.Repository = new DefaultRepository(unitOfWork);                        

                // Execute command
                var result = command.Execute(pageContent.Id);

                // Should return 4 options: 2 with assigned values, 1 without parent option and 1 unassigned
                Assert.IsNotNull(result);
                Assert.IsNotNull(result.WidgetOptions);
                Assert.AreEqual(result.WidgetOptions.Count, 4);
                Assert.IsNotNull(result.WidgetOptions.FirstOrDefault(o => o.OptionKey == option1.Key 
                    && o.OptionValue == po1.Value
                    && o.OptionDefaultValue == option1.DefaultValue));
                Assert.IsNotNull(result.WidgetOptions.FirstOrDefault(o => o.OptionKey == option2.Key
                    && o.OptionValue == po2.Value
                    && o.OptionDefaultValue == option2.DefaultValue));
                Assert.IsNotNull(result.WidgetOptions.FirstOrDefault(o => o.OptionKey == option3.Key
                    && o.OptionValue == null
                    && o.OptionDefaultValue == option3.DefaultValue));
                Assert.IsNotNull(result.WidgetOptions.FirstOrDefault(o => o.OptionKey == po3.Key
                    && o.OptionValue == po3.Value
                    && o.OptionDefaultValue == null));
            });
        }
    }
}
