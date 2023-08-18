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
        }

    }
}
