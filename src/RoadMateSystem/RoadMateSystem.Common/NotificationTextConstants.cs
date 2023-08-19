namespace RoadMateSystem.Common
{
    using System.Reflection;

    public static class NotificationTextConstants
    {
        public static class GeneralErrors
        {
            public const string ErrorOccurred = "Error occurred! Try again later!";
            public const string SomethingWentWrong = "Something went wrong! Please try again later or contact administrator";
        }

        public static class ReviewNotifications
        {
            public const string ReviewNotFound = "Review not found!";
            public const string NotReviewsOwner = "You are NOT the owner of the review!";
            public const string SuccessfullyAdded = "You successfully added a review!";
            public const string SuccessfullyEdited = "You successfully edited your review!";
            public const string ReviewDeleted = "You deleted your review!";
        }

        public static class CarNotifications
        {
            public const string CarNotFound = "Car not found!";
            public const string CarDeleted = "You deleted the car!";
            public const string CarRecovered = "You recovered the car!";
            public const string SuccessfullyEdited = "You successfully edited the car!";
            public const string SuccessfullyAdded = "You successfully added the car!";
        }

        public static class CarMakeNotifications
        {
            public const string SuccessfullyAdded = "You successfully added the car make!";
            public const string SuccessfullyEdited = "You successfully edited the car make!";
            public const string CarMakeRecovered = "You recovered the car make!";
            public const string CarMakeDeleted = "You deleted the car make!";
            public const string CarMakeNotFound = "Car make not found!";

        }
        public static class CarColorNotifications
        {
            public const string SuccessfullyAdded = "You successfully added the color!";
            public const string SuccessfullyEdited = "You successfully edited the color!";
            public const string ColorRecovered = "You recovered the color!";
            public const string ColorDeleted = "You deleted the color!";
            public const string ColorNotFound = "Color not found!";

        }
    }
}
