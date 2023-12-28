using System;
using System.Collections.Generic;

namespace EnvironmentalProtectionSurvey.Models;

public partial class FilledSurveyDetail
{
    public string? SurveyTitle { get; set; }

    public string? QuestionTitle { get; set; }

    public string? OptionTitle { get; set; }

    public DateTime FilledSurveyCreate { get; set; }

    public DateTime SurveyCreate { get; set; }

    public DateTime? SurveyEnd { get; set; }

    public int Id { get; set; }

    public int? UserId { get; set; }
}
