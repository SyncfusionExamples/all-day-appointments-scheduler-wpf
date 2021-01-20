using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Media;

namespace WpfScheduler
{
    public class SchedulerViewModel
    {
        public ScheduleAppointmentCollection scheduleAppointmentCollection { get; set; } = new ScheduleAppointmentCollection();
        public SchedulerViewModel()
        {
            scheduleAppointmentCollection.Add(new ScheduleAppointment()
            {
                StartTime = new DateTime(2020, 12, 15, 10, 0, 0),
                EndTime = new DateTime(2020, 12, 15, 12, 0, 0),
                Subject = "Client Meeting",
                Location = "Hutchison road",
                AppointmentBackground = Brushes.Orange,
                Foreground = Brushes.White,
                IsAllDay = true,
            });
        }
    }
}
