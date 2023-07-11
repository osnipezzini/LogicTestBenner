using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

using Font = Microsoft.Maui.Font;

namespace LogTest.Mobile
{
    internal class Utils
    {
        public static async Task ShowSnack(string message)
        {
            var cancellationTokenSource = new CancellationTokenSource();

            var snackbarOptions = new SnackbarOptions
            {
                BackgroundColor = Colors.Red,
                TextColor = Colors.Green,
                ActionButtonTextColor = Colors.Yellow,
                CornerRadius = new CornerRadius(10),
                Font = Font.SystemFontOfSize(14),
                ActionButtonFont = Font.SystemFontOfSize(14),
                CharacterSpacing = 0.5
            };

            TimeSpan duration = TimeSpan.FromSeconds(3);

            var snackbar = Snackbar.Make(message, duration: duration, visualOptions: snackbarOptions);

            await snackbar.Show(cancellationTokenSource.Token);
        }

        public static async Task MakeToast(string message)
        {
            var cancellationTokenSource = new CancellationTokenSource();

            var duration = ToastDuration.Short;
            double fontSize = 14;

            var toast = Toast.Make(message, duration, fontSize);

            await toast.Show(cancellationTokenSource.Token);
        }
    }
}
