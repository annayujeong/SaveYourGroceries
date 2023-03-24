using Quartz.Impl;
using Quartz;
using System;
using SaveYourGroceries;

namespace SaveYourGroceriesLib
{
    public class PriceNotification
    {
        /// <summary>
        /// reference: https://christkho.medium.com/background-job-with-quartz-net-in-c-and-net-core-a5a2f8cb5619
        /// </summary>
        /// <param name="hours">int</param>
        public async void PushNotificationOnFrequencySet(int hours)
        {
            // 1. Create a scheduler Factory
            ISchedulerFactory schedulerFactory = new StdSchedulerFactory();

            // 2. Get and start a scheduler
            IScheduler scheduler = await schedulerFactory.GetScheduler();
            await scheduler.Start();

            // 3. Create a job
            IJobDetail job = JobBuilder.Create<PriceUpdate>()
                    .WithIdentity("push notification job", "push notification group")
                    .Build();

            // 4. Create a trigger
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("push notification trigger", "push notification group")
                .WithSimpleSchedule(x => x.WithIntervalInHours(hours).RepeatForever())
                .Build();

            // 5. Schedule the job using the job and trigger 
            await scheduler.ScheduleJob(job, trigger);
            Console.ReadLine();
        }

    }
}
