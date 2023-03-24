using Quartz.Impl;
using Quartz;
using System;
using SaveYourGroceries;

namespace SaveYourGroceriesLib
{
    public class PriceNotification
    {
        public async void PushNotificationOnFrequencySet(int hours)
        {
            // 1. Create a scheduler Factory
            ISchedulerFactory schedulerFactory = new StdSchedulerFactory();

            // 2. Get and start a scheduler
            IScheduler scheduler = await schedulerFactory.GetScheduler();
            await scheduler.Start();

            // 3. Create a job
            IJobDetail job = JobBuilder.Create<PriceUpdate>()
                    .WithIdentity("number generator job", "number generator group")
                    .Build();

            // 4. Create a trigger
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("number generator trigger", "number generator group")
                .WithSimpleSchedule(x => x.WithIntervalInSeconds(hours).RepeatForever())
                //.WithSimpleSchedule(x => x.WithIntervalInHours(hours).RepeatForever())
                .Build();

            // 5. Schedule the job using the job and trigger 
            await scheduler.ScheduleJob(job, trigger);
            Console.ReadLine();
        }

    }
}
