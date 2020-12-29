using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Training.Model;

namespace Training.ViewModel
{
    public class SessionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = null) =>
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public ObservableCollection<Session> Sessions { get; set; }

        public SessionViewModel()
        {
            Sessions = new ObservableCollection<Session>();
            var data = new SessionRepo().GetSessions();
            foreach (var session in data)
            {
                Sessions.Add(session);
            }
        }
    }
}
