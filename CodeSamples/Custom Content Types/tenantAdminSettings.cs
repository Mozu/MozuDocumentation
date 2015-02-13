staticvoid WriteEntityManagerEnabledSetting(IApiContext apiContext)
        {
            var entityResource = new Mozu.Api.Resources.Platform.Entitylists.EntityResource(apiContext);
            JObject globalSetting = null;
            try
            {
                globalSetting = entityResource.GetEntity("tenantadminsettings@mozu", "global");
                globalSetting["entityManagerVisible"] = true;
                globalSetting["siteBuilderContentListsVisible"] = true;
                globalSetting["customRoutesVisible"] = true;
                entityResource.UpdateEntity(globalSetting, "tenantadminsettings@mozu", "global");
            }
            catch (ApiException exc)
            {
                if (string.Equals(exc.ErrorCode, "ITEM_NOT_FOUND"))
                {
                    globalSetting = newJObject();
                    globalSetting["name"] = "global";
                    globalSetting["entityManagerVisible"] = true;
                    globalSetting["siteBuilderContentListsVisible"] = true;
                    globalSetting["customRoutesVisible"] = true;
                    entityResource.InsertEntity(globalSetting, "tenantadminsettings@mozu");
                }
                else
                {
                    throw;
                }
            }
        }
