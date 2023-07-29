namespace RoadMateSystem.Common
{
    public static class EntityValidationConstants
    {
        public static class Car 
        {
            public const int MakeMaxLength = 20;
            public const int MakeMinLength = 2;

            public const int ModelMaxLength = 40;
            public const int ModelMinLength = 2;

            public const int HorsepowerMaxValue = 1000;
            public const int HorsepowerMinValue = 40;

            public const int EngineCapacityMaxValue = 8000;
            public const int EngineCapacityMinValue = 0;

            public const int SeatsMaxValue = 11;
            public const int SeatsMinValue = 2;

            public const int DoorsMaxValue = 5;
            public const int DoorsMinValue = 2;

            public const int DescriptionMaxLength = 1000;

            public const int PricePerDayMaxValue = 500;
            public const int PricePerDayMinValue = 20;
        }

        public static class Review
        {
            public const int RatingMaxValue = 10;
            public const int RatingMinValue = 1;

            public const int CommentMaxValue = 500;
        }

        public static class ApplicationUser 
        {
            public const int FirstNameMaxLength = 20;
            public const int FirstNameMinLength = 2;

            public const int LastNameMaxLength = 20;
            public const int LastNameMinLength = 2;

            public const int PhoneNumberLength = 9;

            public const int AddressMaxLength = 70;
            public const int AddressMinLength = 10;
        }

        public static class CarImage
        {
            public const int CaptionMaxLength = 20;
        }
    }
}
