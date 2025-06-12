﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace api.Data;

public class TriggerConfig : IModelFinalizingConvention
{
    public void ProcessModelFinalizing(IConventionModelBuilder modelBuilder,
        IConventionContext<IConventionModelBuilder> context)
    {
        foreach (var entityType in modelBuilder.Metadata.GetEntityTypes()) 
        {
            var table = StoreObjectIdentifier.Create(entityType, StoreObjectType.Table);
            if (table != null && entityType.GetDeclaredTriggers().All(t => t.GetDatabaseName(table.Value) == null) &&
                (entityType.BaseType == null ||
                 entityType.GetMappingStrategy() != RelationalAnnotationNames.TphMappingStrategy))
            {
                entityType.Builder.HasTrigger(table.Value.Name + "_Trigger");
            }
            
            foreach (var fragment in entityType.GetMappingFragments(StoreObjectType.Table))
            {
                if (entityType.GetDeclaredTriggers().All(t => t.GetDatabaseName(fragment.StoreObject) == null))
                {
                    entityType.Builder.HasTrigger(fragment.StoreObject.Name + "_Trigger");
                }
            }
        }

    }
}