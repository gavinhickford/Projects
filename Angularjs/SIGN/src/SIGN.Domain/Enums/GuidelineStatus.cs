namespace SIGN.Domain.Enums
{
    public enum GuidelineStatus
    {
        None = 0,
        CurrentLessThanThreeYears = 1,
        CurrentThreeToSevenYears = 2,
        GreaterThanSevenYears = 3,
        Withdrawn = 4,
        BeingUpdated = 5
    }
}