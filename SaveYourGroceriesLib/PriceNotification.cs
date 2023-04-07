using Quartz.Impl;
using Quartz;
using SaveYourGroceries;


namespace SaveYourGroceriesLib
{
    /// <summary>
    /// Author: Anna
    /// Contain push notification functionality.
    /// reference: https://christkho.medium.com/background-job-with-quartz-net-in-c-and-net-core-a5a2f8cb5619
    /// </summary>
    public class PriceNotification
    {
        /// <summary>
        /// Create scheduler factory and the job to enable pushing notification on price update
        /// depending on whether the user turned the notification setting on and how often they want to get notified.
        /// </summary>
        /// <param name="hours">int</param>
        public async void PushNotificationOnFrequencySet(int hours)
        {
            // Create a scheduler Factory
            ISchedulerFactory schedulerFactory = new StdSchedulerFactory();

            // Get and start a scheduler
            IScheduler scheduler = await schedulerFactory.GetScheduler();
            await scheduler.Start();

            // Create PriceUpdate job
            IJobDetail job = JobBuilder.Create<PriceUpdate>()
                    .WithIdentity("push notification job", "push notification group")
                    .Build();

            // Create a trigger
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("push notification trigger", "push notification group")
                .WithSimpleSchedule(x => x.WithIntervalInHours(hours).RepeatForever())
                .Build();

            // Schedule the job using the job and trigger 
            await scheduler.ScheduleJob(job, trigger);
        }

    }
}
