using System;
using Sitecore.DataExchange.Contexts;
using Sitecore.DataExchange.Providers.Sc.Plugins;
using Sitecore.DataExchange.Repositories;
using Sitecore.Services.Core.Diagnostics;
using Sitecore.Services.Core.Model;

namespace Sitecore.Support.DataExchange.Providers.Sc.Processors.PipelineSteps
{
    public class ResolveMultilanguageSitecoreItemDictionaryPipelineStep : Sitecore.DataExchange.Providers.Sc.Processors.PipelineSteps.ResolveMultilanguageSitecoreItemDictionaryPipelineStep
    {
        protected override ItemModel CreateItemModel(object identifierObject, IItemModelRepository repository, ResolveSitecoreItemSettings settings, PipelineContext pipelineContext, ILogger logger, string language = null, int version = 0)
        {
            var parentItemId = this.GetParentItemIdForNewItem(repository, settings, pipelineContext, logger);
            var itemModel = base.CreateItemModel(identifierObject, repository, settings, pipelineContext, logger, language, version);
            if (itemModel != null)
            {
                itemModel[ItemModel.ParentID] = parentItemId;
            }

            return itemModel;
        }
    }
}