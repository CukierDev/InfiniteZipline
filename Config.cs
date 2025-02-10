using RedLoader;
using SUI;

namespace InfiniteZipline;

public static class Config
{
    public static ConfigCategory Category { get; private set; }
    public static ConfigEntry<float> MaxRopeLength { get; private set; }
    public static ConfigEntry<float> MaxFiringLength { get; private set; }
    public static ConfigEntry<float> MaxVelocity { get; private set; }
    public static ConfigEntry<float> AccelForce { get; private set; }
    public static ConfigEntry<float> ZiplineThreshold { get; private set; }
    public static ConfigEntry<bool> ZiplineScaleWithLength { get; private set; }

    public static void Init()
    {
        Category = ConfigSystem.CreateFileCategory("InfiniteZipline", "InfiniteZipline", "InfiniteZipline.cfg");

        MaxRopeLength = Category.CreateEntry(
            "max_rope_length",
            15000000f,
            "Max Rope Length",
            "Max Length for Ziplines (game default: 150)");
        MaxRopeLength.SetRange(10f,15000000f);

        MaxFiringLength = Category.CreateEntry(
            "max_firing_length",
            50000f,
            "Max Firing Distance",
            "Max Range for firing the Rope Gun");
        MaxFiringLength.SetRange(10f,50000f);

        MaxVelocity = Category.CreateEntry(
            "max_velocity",
            100f,
            "Max Zipline Velocity",
            "Max Velocity for Ziplines, applies only when the zipline length is greater than the threshold length");
        MaxVelocity.SetRange(1f,100000f);

        AccelForce = Category.CreateEntry(
            "accel_force",
            10f,
            "Zipline Acceleration",
            "Acceleration for Ziplines, applies only when the zipline length is greater than the threshold length");
        AccelForce.SetRange(1f,10000f);

        ZiplineThreshold = Category.CreateEntry(
            "zipline_threshold",
            300f,
            "Zipline Length Threshold",
            "The minimum length a zipline has to be to use custom configurations");
        ZiplineThreshold.SetRange(200f,1000f);

        ZiplineScaleWithLength = Category.CreateEntry(
            "zipline_scale_with_length",
            true,
            "Scale With Length",
            "Should the Acceleration and Velocity be scaled with length?");
    }

    // Same as the callback in "CreateSettings". Called when the settings ui is closed.
    public static void OnSettingsUiClosed()
    {
    }
}