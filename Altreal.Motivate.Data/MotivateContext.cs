using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altreal.Motivate.Data.Seeders;
using Altreal.Motivate.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Altreal.Motivate.Data
{
    public class MotivateContext: DbContext
    {
        public MotivateContext(DbContextOptions<MotivateContext> options) : base(options)
        {
            
        }
        //private readonly IConfiguration _configuration;

        //public MotivateContext(IConfiguration _configuration)
        //{
        //    this._configuration = _configuration;
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            //optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Motivate;Integrated Security=True");
            //optionsBuilder.Options.se
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<BehaviorGroup>().HasData(BehaviorGroupSeeder.Seed());
        }

        public DbSet<ActionGoal> ActionGoals { get; set; }
        public DbSet<ActionPlan> ActionPlans { get; set; }
        public DbSet<ActionPlanActionStep> ActionPlanActionSteps { get; set; }
        public DbSet<ActionPlanBehavior> ActionPlanBehaviors { get; set; }
        public DbSet<ActionPlanReminder> ActionPlanReminders { get; set; }
        public DbSet<ActionStep> ActionSteps { get; set; }
        public DbSet<Behavior> Behaviors { get; set; }
        public DbSet<BehaviorGroup> BehaviorGroups { get; set; }
        public DbSet<Culture> Cultures { get; set; }
        public DbSet<JournalBehavior> JournalBehaviors { get; set; }
        public DbSet<JournalEntry> JournalEntries { get; set; }
        public DbSet<JournalMedia> JournalMedia { get; set; }
        public DbSet<Observer> Observers { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrganizationGoal> OrganizationGoals { get; set; }
        public DbSet<OrganizationPulseSurveyQuestion> OrganizationPulseSurveyQuestions { get; set; }
        public DbSet<PulseSurvey> PulseSurveys { get; set; }
        public DbSet<PulseSurveyBehaviorResult> PulseSurveyBehaviorResults { get; set; }
        public DbSet<PulseSurveyQuestion> PulseSurveyQuestions { get; set; }
        public DbSet<PulseSurveyResult> PulseSurveyResults { get; set; }
        public  DbSet<Timezone> Timezones { get; set; }
        public DbSet<Translation> Translations { get; set; }
    }
}
