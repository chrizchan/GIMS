using AutoMapper;


namespace GIMS.ViewModel.Configuration
{
    public static class MappingConfig
    {
        public static void RegisterMaps()
        {
            ConfigureMapping();
        }

        private static void ConfigureMapping()
        {

            Mapper.Initialize(x =>
            {
                //x.AddProfile<CategorySettingMappingProfile>();

            });

        }

    }
}