using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altreal.Motivate.Shared.Models;

namespace Altreal.Motivate.Data.Seeders
{
    public static class AdminUserSeed
    {
        public static Guid Id => new Guid("139A30BE-1FB0-4BED-A0B3-8EB12A6744DD");
    }

    public static class BehaviorSeeder
    {
        public static Behavior[] Seed()
        {
            return new Behavior[]
            {
                new Behavior
                {
                    Id = new Guid("D07B1934-7094-46A9-9AC7-B3546DD5FCC7"),
                    CreatedBy = AdminUserSeed.Id,
                    CreatedAt = DateTime.UtcNow,
                    NameKey = "behavior.conservative.label",
                    ReportTextKey = "behavior.conservative.report_text",
                    RatingFeedbackQuestionKey = "behavior.conservative.rating_feedback_question",
                    AdditionalFeedbackQuestionKey = "behavior.conservative.additional_feedback_question",
                    LowLabelKey = "behavior.conservative.low_label",
                    HighLabelKey = "behavior.conservative.high_label",
                    Order = 0
                },
                new Behavior
                {
                    Id = new Guid("6A0FA43F-D12F-4B1F-9955-9AF1704930D3"),
                    CreatedBy = AdminUserSeed.Id,
                    CreatedAt = DateTime.UtcNow,
                    NameKey = "behavior.innovative.label",
                    ReportTextKey = "behavior.innovative.report_text",
                    RatingFeedbackQuestionKey = "behavior.innovative.rating_feedback_question",
                    AdditionalFeedbackQuestionKey = "behavior.innovative.additional_feedback_question",
                    LowLabelKey = "behavior.innovative.low_label",
                    HighLabelKey = "behavior.innovative.high_label",
                    Order = 1
                },
                new Behavior
                {
                    Id = new Guid("C92B0696-B34F-47E4-B4B4-886A4B8890A5"),
                    CreatedBy = AdminUserSeed.Id,
                    CreatedAt = DateTime.UtcNow,
                    NameKey = "behavior.technical.label",
                    ReportTextKey = "behavior.technical.report_text",
                    RatingFeedbackQuestionKey = "behavior.technical.rating_feedback_question",
                    AdditionalFeedbackQuestionKey = "behavior.technical.additional_feedback_question",
                    LowLabelKey = "behavior.technical.low_label",
                    HighLabelKey = "behavior.technical.high_label",
                    Order = 2
                },
                new Behavior
                {
                    Id = new Guid("19B61049-36BA-4E2E-A952-8A2CBF5C5FAB"),
                    CreatedBy = AdminUserSeed.Id,
                    CreatedAt = DateTime.UtcNow,
                    NameKey = "behavior.self.label",
                    ReportTextKey = "behavior.self.report_text",
                    RatingFeedbackQuestionKey = "behavior.self.rating_feedback_question",
                    AdditionalFeedbackQuestionKey = "behavior.self.additional_feedback_question",
                    LowLabelKey = "behavior.self.low_label",
                    HighLabelKey = "behavior.self.high_label",
                    Order = 3
                },
                new Behavior
                {
                    Id = new Guid("1B225410-3026-472A-85E0-D5403F248CCF"),
                    CreatedBy = AdminUserSeed.Id,
                    CreatedAt = DateTime.UtcNow,
                    NameKey = "behavior.strategic.label",
                    ReportTextKey = "behavior.strategic.report_text",
                    RatingFeedbackQuestionKey = "behavior.strategic.rating_feedback_question",
                    AdditionalFeedbackQuestionKey = "behavior.strategic.additional_feedback_question",
                    LowLabelKey = "behavior.strategic.low_label",
                    HighLabelKey = "behavior.strategic.high_label",
                    Order = 4,
                },
                new Behavior
                    {
                        Id = new Guid("AFF6E5E5-F6F7-4AB4-973B-017D77A78CEA"),
                        CreatedBy = AdminUserSeed.Id,
                        CreatedAt = DateTime.UtcNow,
                        NameKey = "behavior.persuasive.label",
                        ReportTextKey = "behavior.persuasive.report_text",
                        RatingFeedbackQuestionKey = "behavior.persuasive.rating_feedback_question",
                        AdditionalFeedbackQuestionKey = "behavior.persuasive.additional_feedback_question",
                        LowLabelKey = "behavior.persuasive.low_label",
                        HighLabelKey = "behavior.persuasive.high_label",
                        Order = 5
                    },
                    new Behavior
                    {
                        Id = new Guid("5E14ECAE-F6FB-4CB7-AD1F-27E73D1907C4"),
                        CreatedBy = AdminUserSeed.Id,
                        CreatedAt = DateTime.UtcNow,
                        NameKey = "behavior.outgoing.label",
                        ReportTextKey = "behavior.outgoing.report_text",
                        RatingFeedbackQuestionKey = "behavior.outgoing.rating_feedback_question",
                        AdditionalFeedbackQuestionKey = "behavior.outgoing.additional_feedback_question",
                        LowLabelKey = "behavior.outgoing.low_label",
                        HighLabelKey = "behavior.outgoing.high_label",
                        Order = 6
                    },
                    new Behavior
                    {
                        Id = new Guid("E8F1CDFC-B3FF-4387-B47A-5331D06B5C8F"),
                        CreatedBy = AdminUserSeed.Id,
                        CreatedAt = DateTime.UtcNow,
                        NameKey = "behavior.excitement.label",
                        ReportTextKey = "behavior.excitement.report_text",
                        RatingFeedbackQuestionKey = "behavior.excitement.rating_feedback_question",
                        AdditionalFeedbackQuestionKey = "behavior.excitement.additional_feedback_question",
                        LowLabelKey = "behavior.excitement.low_label",
                        HighLabelKey = "behavior.excitement.high_label",
                        Order = 7
                    },
                    new Behavior
                    {
                        Id = new Guid("C7D2003B-0ABB-44A0-A132-AFFA4A456A39"),
                        CreatedBy = AdminUserSeed.Id,
                        CreatedAt = DateTime.UtcNow,
                        NameKey = "behavior.restraint.label",
                        ReportTextKey = "behavior.restraint.report_text",
                        RatingFeedbackQuestionKey = "behavior.restraint.rating_feedback_question",
                        AdditionalFeedbackQuestionKey = "behavior.restraint.additional_feedback_question",
                        LowLabelKey = "behavior.restraint.low_label",
                        HighLabelKey = "behavior.restraint.high_label",
                        Order = 8
                    },
                    new Behavior
                    {
                        Id = new Guid("D5DDF6E0-DADA-4A8A-92F9-E01F7C56545E"),
                        CreatedBy = AdminUserSeed.Id,
                        CreatedAt = DateTime.UtcNow,
                        NameKey = "behavior.structuring.label",
                        ReportTextKey = "behavior.structuring.report_text",
                        RatingFeedbackQuestionKey = "behavior.structuring.rating_feedback_question",
                        AdditionalFeedbackQuestionKey = "behavior.structuring.additional_feedback_question",
                        LowLabelKey = "behavior.structuring.low_label",
                        HighLabelKey = "behavior.structuring.high_label",
                        Order = 9
                    },
                    new Behavior
                    {
                        Id = new Guid("AF237A2E-BE23-4351-9F7B-25FDEF5D4CA5"),
                        CreatedBy = AdminUserSeed.Id,
                        CreatedAt = DateTime.UtcNow,
                        NameKey = "behavior.tactical.label",
                        ReportTextKey = "behavior.tactical.report_text",
                        RatingFeedbackQuestionKey = "behavior.tactical.rating_feedback_question",
                        AdditionalFeedbackQuestionKey = "behavior.tactical.additional_feedback_question",
                        LowLabelKey = "behavior.tactical.low_label",
                        HighLabelKey = "behavior.tactical.high_label",
                        Order = 10
                    },
                    new Behavior
                    {
                        Id = new Guid("2AED10B5-E49D-4253-A52B-0C518FDE7BD1"),
                        CreatedBy = AdminUserSeed.Id,
                        CreatedAt = DateTime.UtcNow,
                        NameKey = "behavior.communication.label",
                        ReportTextKey = "behavior.communication.report_text",
                        RatingFeedbackQuestionKey = "behavior.communication.rating_feedback_question",
                        AdditionalFeedbackQuestionKey = "behavior.communication.additional_feedback_question",
                        LowLabelKey = "behavior.communication.low_label",
                        HighLabelKey = "behavior.communication.high_label",
                        Order = 11
                    },
                    new Behavior
                    {
                        Id = new Guid("F24B5D1C-531D-4200-BA03-9A892BD0FD4B"),
                        CreatedBy = AdminUserSeed.Id,
                        CreatedAt = DateTime.UtcNow,
                        NameKey = "behavior.delegation.label",
                        ReportTextKey = "behavior.delegation.report_text",
                        RatingFeedbackQuestionKey = "behavior.delegation.rating_feedback_question",
                        AdditionalFeedbackQuestionKey = "behavior.delegation.additional_feedback_question",
                        LowLabelKey = "behavior.delegation.low_label",
                        HighLabelKey = "behavior.delegation.high_label",
                        Order = 12
                    },
                    new Behavior
                    {
                        Id = new Guid("7E67F0FF-B1BE-4402-BFDE-4353BB7ABDEA"),
                        CreatedBy = AdminUserSeed.Id,
                        CreatedAt = DateTime.UtcNow,
                        NameKey = "behavior.control.label",
                        ReportTextKey = "behavior.control.report_text",
                        RatingFeedbackQuestionKey = "behavior.control.rating_feedback_question",
                        AdditionalFeedbackQuestionKey = "behavior.control.additional_feedback_question",
                        LowLabelKey = "behavior.control.low_label",
                        HighLabelKey = "behavior.control.high_label",
                        Order = 13
                    },
                    new Behavior
                    {
                        Id = new Guid("0ED90A85-14B3-4004-B820-5CF89EF43DBB"),
                        CreatedBy = AdminUserSeed.Id,
                        CreatedAt = DateTime.UtcNow,
                        NameKey = "behavior.feedback.label",
                        ReportTextKey = "behavior.feedback.report_text",
                        RatingFeedbackQuestionKey = "behavior.feedback.rating_feedback_question",
                        AdditionalFeedbackQuestionKey = "behavior.feedback.additional_feedback_question",
                        LowLabelKey = "behavior.feedback.low_label",
                        HighLabelKey = "behavior.feedback.high_label",
                        Order = 14
                    },
                    new Behavior
                    {
                        Id = new Guid("D0B6CE91-3DF4-4B61-AE03-CEC1D90582D7"),
                        CreatedBy = AdminUserSeed.Id,
                        CreatedAt = DateTime.UtcNow,
                        NameKey = "behavior.management_focus.label",
                        ReportTextKey = "behavior.management_focus.report_text",
                        RatingFeedbackQuestionKey = "behavior.management_focus.rating_feedback_question",
                        AdditionalFeedbackQuestionKey = "behavior.management_focus.additional_feedback_question",
                        LowLabelKey = "behavior.management_focus.low_label",
                        HighLabelKey = "behavior.management_focus.high_label",
                        Order = 15
                    },
                    new Behavior
                    {
                        Id = new Guid("483940CC-B935-4853-9679-93CE2302C34E"),
                        CreatedBy = AdminUserSeed.Id,
                        CreatedAt = DateTime.UtcNow,
                        NameKey = "behavior.dominant.label",
                        ReportTextKey = "behavior.dominant.report_text",
                        RatingFeedbackQuestionKey = "behavior.dominant.rating_feedback_question",
                        AdditionalFeedbackQuestionKey = "behavior.dominant.additional_feedback_question",
                        LowLabelKey = "behavior.dominant.low_label",
                        HighLabelKey = "behavior.dominant.high_label",
                        Order = 16
                    },
                    new Behavior
                    {
                        Id = new Guid("266574F7-776B-4EC6-BEDA-0D4953E11B2E"),
                        CreatedBy = AdminUserSeed.Id,
                        CreatedAt = DateTime.UtcNow,
                        NameKey = "behavior.production.label",
                        ReportTextKey = "behavior.production.report_text",
                        RatingFeedbackQuestionKey = "behavior.production.rating_feedback_question",
                        AdditionalFeedbackQuestionKey = "behavior.production.additional_feedback_question",
                        LowLabelKey = "behavior.production.low_label",
                        HighLabelKey = "behavior.production.high_label",
                        Order = 17
                    },
                    new Behavior
                    {
                        Id = new Guid("FC032A9E-4B5D-4EC2-BD22-9BAC3BC6E093"),
                        CreatedBy = AdminUserSeed.Id,
                        CreatedAt = DateTime.UtcNow,
                        NameKey = "behavior.cooperation.label",
                        ReportTextKey = "behavior.cooperation.report_text",
                        RatingFeedbackQuestionKey = "behavior.cooperation.rating_feedback_question",
                        AdditionalFeedbackQuestionKey = "behavior.cooperation.additional_feedback_question",
                        LowLabelKey = "behavior.cooperation.low_label",
                        HighLabelKey = "behavior.cooperation.high_label",
                        Order = 18
                    },
                    new Behavior
                    {
                        Id = new Guid("1BC7CD40-EC9F-4F3A-A40D-5A05CD06212B"),
                        CreatedBy = AdminUserSeed.Id,
                        CreatedAt = DateTime.UtcNow,
                        NameKey = "behavior.consensual.label",
                        ReportTextKey = "behavior.consensual.report_text",
                        RatingFeedbackQuestionKey = "behavior.consensual.rating_feedback_question",
                        AdditionalFeedbackQuestionKey = "behavior.consensual.additional_feedback_question",
                        LowLabelKey = "behavior.consensual.low_label",
                        HighLabelKey = "behavior.consensual.high_label",
                        Order = 19
                    },
                    new Behavior
                    {
                        Id = new Guid("B1700D48-0337-4CAB-A99F-971440051CC5"),
                        CreatedBy = AdminUserSeed.Id,
                        CreatedAt = DateTime.UtcNow,
                        NameKey = "behavior.authority.label",
                        ReportTextKey = "behavior.authority.report_text",
                        RatingFeedbackQuestionKey = "behavior.authority.rating_feedback_question",
                        AdditionalFeedbackQuestionKey = "behavior.authority.additional_feedback_question",
                        LowLabelKey = "behavior.authority.low_label",
                        HighLabelKey = "behavior.authority.high_label",
                        Order = 20
                    },
                    new Behavior
                    {
                        Id = new Guid("786BF02C-F992-4423-95EB-E4F4AAB0D6A4"),
                        CreatedBy = AdminUserSeed.Id,
                        CreatedAt = DateTime.UtcNow,
                        NameKey = "behavior.empathy.label",
                        ReportTextKey = "behavior.empathy.report_text",
                        RatingFeedbackQuestionKey = "behavior.empathy.rating_feedback_question",
                        AdditionalFeedbackQuestionKey = "behavior.empathy.additional_feedback_question",
                        LowLabelKey = "behavior.empathy.low_label",
                        HighLabelKey = "behavior.empathy.high_label",
                        Order = 21
                    }
            };
        }
    }

    public static class BehaviorGroupSeeder
    {
        public static BehaviorGroup[] Seed()
        {
            var groups = new List<BehaviorGroup>
            {
                new BehaviorGroup
                {
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = AdminUserSeed.Id,
                    Id = new Guid("1BD7DA5D-F8E0-490E-A20F-14CEAB6EC3DB"),
                    NameKey = "behavior.group.creating_vision.label",
                    Order = 0,
                },
                new BehaviorGroup
                {
                    Id = new Guid("1A4E10C8-E532-4DFB-949A-475562A7B457"),
                    CreatedBy = AdminUserSeed.Id,
                    CreatedAt = DateTime.UtcNow,
                    Order = 1,
                    NameKey = "behavior.group.followership.label"
                },
                new BehaviorGroup
                {
                    Id = new Guid("95E3AFA5-77B4-4A11-9AD7-551F87A0D7A3"),
                    Order = 2,
                    CreatedBy = AdminUserSeed.Id,
                    CreatedAt = DateTime.UtcNow,
                    NameKey = "behavior.group.implementing_vision.label",
                },
                new BehaviorGroup
                {
                    Id = new Guid("AFB816F9-1A10-410A-9859-98A5692FA60F"),
                    CreatedBy = AdminUserSeed.Id,
                    Order = 3,
                    NameKey = "behavior.group.following_through.label",
                    CreatedAt = DateTime.UtcNow,
                },
                new BehaviorGroup
                {
                    Id = new Guid("41FD3FB3-4BB3-4034-9987-8F7F19A6CA97"),
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = AdminUserSeed.Id,
                    Order = 4,
                    NameKey = "behavior.achieving_results.label",
                },
                new BehaviorGroup
                {
                    Id = new Guid("3D31AB36-4CB2-4319-9043-71023FBF8D6C"),
                    CreatedBy = AdminUserSeed.Id,
                    CreatedAt = DateTime.UtcNow,
                    Order = 5,
                    NameKey = "behavior.group.team_playing.label",
                }
            };

            return groups.ToArray();
        }
    }
}
