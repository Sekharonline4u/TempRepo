using System;
using Xamarin.Forms;

namespace Training.Triggers
{
    public class AgeVerificationTrigger : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            var entry = sender as Entry;
            var flag = int.TryParse(entry.Text, out int age);
            entry.BackgroundColor = ((!flag) || (age < 18 || age > 80)) ?
                Color.Red : Color.Default;
        }
    }
}
