﻿USE [Motivate]
GO
INSERT [dbo].[BehaviorGroups] ([Id], [NameKey], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'1bd7da5d-f8e0-490e-a20f-14ceab6ec3db', N'behavior.group.creating_vision.label', 0, CAST(N'2022-02-16T13:37:50.0366667' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[BehaviorGroups] ([Id], [NameKey], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'1a4e10c8-e532-4dfb-949a-475562a7b457', N'behavior.group.followership.label', 1, CAST(N'2022-02-16T13:37:50.0366667' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[BehaviorGroups] ([Id], [NameKey], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'95e3afa5-77b4-4a11-9ad7-551f87a0d7a3', N'behavior.group.implementing_vision.label', 2, CAST(N'2022-02-16T13:37:50.0366667' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[BehaviorGroups] ([Id], [NameKey], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'3d31ab36-4cb2-4319-9043-71023fbf8d6c', N'behavior.group.team_playing.label', 5, CAST(N'2022-02-16T13:37:50.0366667' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[BehaviorGroups] ([Id], [NameKey], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'41fd3fb3-4bb3-4034-9987-8f7f19a6ca97', N'behavior.achieving_results.label', 4, CAST(N'2022-02-16T13:37:50.0366667' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[BehaviorGroups] ([Id], [NameKey], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'afb816f9-1a10-410a-9859-98a5692fa60f', N'behavior.group.following_through.label', 3, CAST(N'2022-02-16T13:37:50.0366667' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'28c1af2f-bf69-44c5-9090-02457d72ee79', N'behavior.consensual.label', N'behavior.consensual.report_text', N'behavior.consensual.rating_feedback_question', N'behavior.consensual.additional_feedback_question', N'behavior.consensual.low_label', N'behavior.consensual.high_label', N'3d31ab36-4cb2-4319-9043-71023fbf8d6c', 19, CAST(N'2022-02-16T13:53:56.7866667' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'defbd145-8f80-4e0b-bbf3-050e4f629d89', N'behavior.empathy.label', N'behavior.empathy.report_text', N'behavior.empathy.rating_feedback_question', N'behavior.empathy.additional_feedback_question', N'behavior.empathy.low_label', N'behavior.empathy.high_label', N'3d31ab36-4cb2-4319-9043-71023fbf8d6c', 21, CAST(N'2022-02-16T13:54:34.4766667' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'8c5da009-9f72-4f65-80fb-079cf29a1267', N'behavior.excitement.label', N'behavior.excitement.report_text', N'behavior.excitement.rating_feedback_question', N'behavior.excitement.additional_feedback_question', N'behavior.excitement.low_label', N'behavior.excitement.high_label', N'1a4e10c8-e532-4dfb-949a-475562a7b457', 7, CAST(N'2022-02-16T13:46:05.2200000' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'd8b37d7f-e231-4c26-a453-0e6b70ec267b', N'behavior.structuring.label', N'behavior.structuring.report_text', N'behavior.structuring.rating_feedback_question', N'behavior.structuring.additional_feedback_question', N'behavior.structuring.low_label', N'behavior.structuring.high_label', N'95e3afa5-77b4-4a11-9ad7-551f87a0d7a3', 8, CAST(N'2022-02-16T13:46:47.1966667' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'5b211760-be78-4bed-bfaa-11606f4b03d8', N'behavior.delegation.label', N'behavior.delegation.report_text', N'behavior.delegation.rating_feedback_question', N'behavior.delegation.additional_feedback_question', N'behavior.delegation.low_label', N'behavior.delegation.high_label', N'95e3afa5-77b4-4a11-9ad7-551f87a0d7a3', 12, CAST(N'2022-02-16T13:50:56.1000000' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'9ac45c67-553f-47e1-a726-1d5c7d97cf5b', N'behavior.structuring.label', N'behavior.structuring.report_text', N'behavior.structuring.rating_feedback_question', N'behavior.structuring.additional_feedback_question', N'behavior.structuring.low_label', N'behavior.structuring.high_label', N'95e3afa5-77b4-4a11-9ad7-551f87a0d7a3', 9, CAST(N'2022-02-16T13:48:02.1033333' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'a2b26c00-0cde-46a7-a8b0-1ef2167a0d82', N'behavior.tactical.label', N'behavior.tactical.report_text', N'behavior.tactical.rating_feedback_question', N'behavior.tactical.additional_feedback_question', N'behavior.tactical.low_label', N'behavior.tactical.high_label', N'95e3afa5-77b4-4a11-9ad7-551f87a0d7a3', 10, CAST(N'2022-02-16T13:49:00.0633333' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'0c8dba46-6657-4a86-93f7-27f5c95dd77f', N'behavior.innovative.label', N'behavior.innovative.report_text', N'behavior.innovative.rating_feedback_question', N'behavior.innovative.additional_feedback_question', N'behavior.innovative.low_label', N'behavior.innovative.high_label', N'1bd7da5d-f8e0-490e-a20f-14ceab6ec3db', 1, CAST(N'2022-02-16T13:43:14.7700000' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'2d10601b-e19a-450a-89be-2f102e47e1fe', N'behavior.strategic.label', N'behavior.strategic.report_text', N'behavior.strategic.rating_feedback_question', N'behavior.strategic.additional_feedback_question', N'behavior.strategic.low_label', N'behavior.strategic.high_label', N'1bd7da5d-f8e0-490e-a20f-14ceab6ec3db', 4, CAST(N'2022-02-16T13:44:23.8066667' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'7322d49b-bdd1-41bd-bfd7-3a093b1d5ff6', N'behavior.management_focus.label', N'behavior.management_focus.report_text', N'behavior.management_focus.rating_feedback_question', N'behavior.management_focus.additional_feedback_question', N'behavior.management_focus.low_label', N'behavior.management_focus.high_label', N'41fd3fb3-4bb3-4034-9987-8f7f19a6ca97', 15, CAST(N'2022-02-16T13:52:18.8733333' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'99398037-ecb9-437c-8e9d-57f938390fe8', N'behavior.dominant.label', N'behavior.dominant.report_text', N'behavior.dominant.rating_feedback_question', N'behavior.dominant.additional_feedback_question', N'behavior.dominant.low_label', N'behavior.dominant.high_label', N'41fd3fb3-4bb3-4034-9987-8f7f19a6ca97', 16, CAST(N'2022-02-16T13:52:37.3833333' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'7c5bbcc8-a340-46af-878a-75bccede9629', N'behavior.outgoing.label', N'behavior.outgoing.report_text', N'behavior.outgoing.rating_feedback_question', N'behavior.outgoing.additional_feedback_question', N'behavior.outgoing.low_label', N'behavior.outgoing.high_label', N'1a4e10c8-e532-4dfb-949a-475562a7b457', 6, CAST(N'2022-02-16T13:45:48.6800000' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'5e324b2d-3d94-4b78-a3d5-7b8dc14c1cf8', N'behavior.production.label', N'behavior.production.report_text', N'behavior.production.rating_feedback_question', N'behavior.production.additional_feedback_question', N'behavior.production.low_label', N'behavior.production.high_label', N'41fd3fb3-4bb3-4034-9987-8f7f19a6ca97', 17, CAST(N'2022-02-16T13:52:59.2500000' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'403741fe-b70a-40eb-9645-87cb9be6af08', N'behavior.conservative.label', N'behavior.conservative.report_text', N'behavior.conservative.rating_feedback_question', N'behavior.conservative.additional_feedback_question', N'behavior.conservative.low_label', N'behavior.conservative.high_label', N'1bd7da5d-f8e0-490e-a20f-14ceab6ec3db', 0, CAST(N'2022-02-16T13:42:46.2266667' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'de00da2b-3249-4135-b230-912c7e530751', N'behavior.authority.label', N'behavior.authority.report_text', N'behavior.authority.rating_feedback_question', N'behavior.authority.additional_feedback_question', N'behavior.authority.low_label', N'behavior.authority.high_label', N'3d31ab36-4cb2-4319-9043-71023fbf8d6c', 20, CAST(N'2022-02-16T13:54:18.9700000' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'cd7e17c6-6452-4779-b65b-9c95b18912c2', N'behavior.restraint.label', N'behavior.restraint.report_text', N'behavior.restraint.rating_feedback_question', N'behavior.restraint.additional_feedback_question', N'behavior.restraint.low_label', N'behavior.restraint.high_label', N'1a4e10c8-e532-4dfb-949a-475562a7b457', 8, CAST(N'2022-02-16T13:46:23.7366667' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'97668ea3-1ef2-4911-9302-9cba9bf2b8e6', N'behavior.control.label', N'behavior.control.report_text', N'behavior.control.rating_feedback_question', N'behavior.control.additional_feedback_question', N'behavior.control.low_label', N'behavior.control.high_label', N'afb816f9-1a10-410a-9859-98a5692fa60f', 13, CAST(N'2022-02-16T13:51:28.7333333' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'3cb84b59-4bad-425f-9ccd-b493fdb9ff8e', N'behavior.cooperation.label', N'behavior.cooperation.report_text', N'behavior.cooperation.rating_feedback_question', N'behavior.cooperation.additional_feedback_question', N'behavior.cooperation.low_label', N'behavior.cooperation.high_label', N'3d31ab36-4cb2-4319-9043-71023fbf8d6c', 18, CAST(N'2022-02-16T13:53:37.6633333' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'5664afa9-3f47-48be-bf6f-ba1dac773149', N'behavior.technical.label', N'behavior.technical.report_text', N'behavior.technical.rating_feedback_question', N'behavior.technical.additional_feedback_question', N'behavior.technical.low_label', N'behavior.technical.high_label', N'1bd7da5d-f8e0-490e-a20f-14ceab6ec3db', 2, CAST(N'2022-02-16T13:43:33.2366667' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'8e6c997a-ac7e-4d28-8527-c7c3cbcfc278', N'behavior.feedback.label', N'behavior.feedback.report_text', N'behavior.feedback.rating_feedback_question', N'behavior.feedback.additional_feedback_question', N'behavior.feedback.low_label', N'behavior.feedback.high_label', N'afb816f9-1a10-410a-9859-98a5692fa60f', 14, CAST(N'2022-02-16T13:51:46.5633333' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'a358fe13-1962-4864-ac1b-d0e2bc27a66e', N'behavior.communication.label', N'behavior.communication.report_text', N'behavior.communication.rating_feedback_question', N'behavior.communication.additional_feedback_question', N'behavior.communication.low_label', N'behavior.communication.high_label', N'95e3afa5-77b4-4a11-9ad7-551f87a0d7a3', 11, CAST(N'2022-02-16T13:49:34.8400000' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'ea7f9e9d-3c11-465f-84a5-ead9086c5ff3', N'behavior.self.label', N'behavior.self.report_text', N'behavior.self.rating_feedback_question', N'behavior.self.additional_feedback_question', N'behavior.self.low_label', N'behavior.self.high_label', N'1bd7da5d-f8e0-490e-a20f-14ceab6ec3db', 3, CAST(N'2022-02-16T13:43:57.8500000' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO
INSERT [dbo].[Behaviors] ([Id], [NameKey], [ReportTextKey], [RatingFeedbackQuestionKey], [AdditionalFeedbackQuestionKey], [LowLabelKey], [HighLabelKey], [BehaviorGroupId], [Order], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'5412cbb2-97f5-4076-b65b-f44236d8593e', N'behavior.persuasive.label', N'behavior.persuasive.report_text', N'behavior.persuasive.rating_feedback_question', N'behavior.persuasive.additional_feedback_question', N'behavior.persuasive.low_label', N'behavior.persuasive.high_label', N'1a4e10c8-e532-4dfb-949a-475562a7b457', 5, CAST(N'2022-02-16T13:45:17.8200000' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO

GO
INSERT [dbo].[Organizations] ([Id], [Name], [Logo], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'f9713e86-f213-4499-90b9-bb60b9ef063f', N'Default', N'', CAST(N'2022-02-16T14:20:02.5400000' AS DateTime2), NULL, NULL, N'd1fd37aa-2346-4328-94ee-e15511e6a93f', NULL, NULL)
GO
INSERT [dbo].[OrganizationGoals] ([Id], [OrganizationId], [QuestionKey], [Type], [Sort], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'90b4285b-e813-4490-9d63-3a84c7267228', N'f9713e86-f213-4499-90b9-bb60b9ef063f', N'action_plan.goals.risks.help_text', 4, 3, CAST(N'2022-02-16T14:23:09.1700000' AS DateTime2), NULL, NULL, N'd1fd37aa-2346-4328-94ee-e15511e6a93f', NULL, NULL)
GO
INSERT [dbo].[OrganizationGoals] ([Id], [OrganizationId], [QuestionKey], [Type], [Sort], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'e7545d66-3ff6-4206-b658-5439055f9177', N'f9713e86-f213-4499-90b9-bb60b9ef063f', N'action_plan.goals.resources.help_text', 6, 5, CAST(N'2022-02-16T14:23:37.1566667' AS DateTime2), NULL, NULL, N'd1fd37aa-2346-4328-94ee-e15511e6a93f', NULL, NULL)
GO
INSERT [dbo].[OrganizationGoals] ([Id], [OrganizationId], [QuestionKey], [Type], [Sort], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'5b317e57-fbb2-4025-b615-5ab2f458aaf7', N'f9713e86-f213-4499-90b9-bb60b9ef063f', N'action_plan.goals.constituents.help_text', 2, 1, CAST(N'2022-02-16T14:22:41.2500000' AS DateTime2), NULL, NULL, N'd1fd37aa-2346-4328-94ee-e15511e6a93f', NULL, NULL)
GO
INSERT [dbo].[OrganizationGoals] ([Id], [OrganizationId], [QuestionKey], [Type], [Sort], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'12b319af-107a-4e0b-a942-716ab7263079', N'f9713e86-f213-4499-90b9-bb60b9ef063f', N'action_plan.goals.benefits.help_text', 3, 2, CAST(N'2022-02-16T14:22:54.7700000' AS DateTime2), NULL, NULL, N'd1fd37aa-2346-4328-94ee-e15511e6a93f', NULL, NULL)
GO
INSERT [dbo].[OrganizationGoals] ([Id], [OrganizationId], [QuestionKey], [Type], [Sort], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'9ca97d85-5e05-4077-95ac-ae7dbfb93416', N'f9713e86-f213-4499-90b9-bb60b9ef063f', N'action_plan.goals.goal.help_text', 1, 0, CAST(N'2022-02-16T14:22:24.4066667' AS DateTime2), NULL, NULL, N'd1fd37aa-2346-4328-94ee-e15511e6a93f', NULL, NULL)
GO
INSERT [dbo].[OrganizationGoals] ([Id], [OrganizationId], [QuestionKey], [Type], [Sort], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'bba17af5-86b7-462f-b9b5-bb6526be5cf1', N'f9713e86-f213-4499-90b9-bb60b9ef063f', N'action_plan.goals.obstacles.help_text', 5, 4, CAST(N'2022-02-16T14:23:20.5866667' AS DateTime2), NULL, NULL, N'd1fd37aa-2346-4328-94ee-e15511e6a93f', NULL, NULL)
GO
INSERT [dbo].[Cultures] ([Id], [Code], [Enabled], [EnglishName], [NameKey], [CreatedAt], [UpdatedAt], [DeletedAt], [CreatedBy], [UpdatedBy], [DeletedBy]) VALUES (N'b773efe0-0b3c-4bf7-95d6-3009d069e14f', N'en_US', 1, N'English (US)', N'en_US', CAST(N'2022-02-16T23:47:30.8900000' AS DateTime2), NULL, NULL, N'139a30be-1fb0-4bed-a0b3-8eb12a6744dd', NULL, NULL)
GO