#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Forem
{
    /// <summary>
    /// Representation of a survey including its polls and poll options
    /// </summary>
    public readonly partial struct SurveyWithPolls : global::System.IEquatable<SurveyWithPolls>
    {
        /// <summary>
        /// Representation of a survey
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Forem.Survey? Survey { get; init; }
#else
        public global::Forem.Survey? Survey { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Survey))]
#endif
        public bool IsSurvey => Survey != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSurvey(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Forem.Survey? value)
        {
            value = Survey;
            return IsSurvey;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Forem.Survey PickSurvey() => IsSurvey
            ? Survey!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Survey' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Forem.SurveyWithPollsVariant2? SurveyWithPollsVariant2 { get; init; }
#else
        public global::Forem.SurveyWithPollsVariant2? SurveyWithPollsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SurveyWithPollsVariant2))]
#endif
        public bool IsSurveyWithPollsVariant2 => SurveyWithPollsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSurveyWithPollsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Forem.SurveyWithPollsVariant2? value)
        {
            value = SurveyWithPollsVariant2;
            return IsSurveyWithPollsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Forem.SurveyWithPollsVariant2 PickSurveyWithPollsVariant2() => IsSurveyWithPollsVariant2
            ? SurveyWithPollsVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SurveyWithPollsVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SurveyWithPolls(global::Forem.Survey value) => new SurveyWithPolls((global::Forem.Survey?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Forem.Survey?(SurveyWithPolls @this) => @this.Survey;

        /// <summary>
        /// 
        /// </summary>
        public SurveyWithPolls(global::Forem.Survey? value)
        {
            Survey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SurveyWithPolls FromSurvey(global::Forem.Survey? value) => new SurveyWithPolls(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SurveyWithPolls(global::Forem.SurveyWithPollsVariant2 value) => new SurveyWithPolls((global::Forem.SurveyWithPollsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Forem.SurveyWithPollsVariant2?(SurveyWithPolls @this) => @this.SurveyWithPollsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SurveyWithPolls(global::Forem.SurveyWithPollsVariant2? value)
        {
            SurveyWithPollsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SurveyWithPolls FromSurveyWithPollsVariant2(global::Forem.SurveyWithPollsVariant2? value) => new SurveyWithPolls(value);

        /// <summary>
        /// 
        /// </summary>
        public SurveyWithPolls(
            global::Forem.Survey? survey,
            global::Forem.SurveyWithPollsVariant2? surveyWithPollsVariant2
            )
        {
            Survey = survey;
            SurveyWithPollsVariant2 = surveyWithPollsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SurveyWithPollsVariant2 as object ??
            Survey as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Survey?.ToString() ??
            SurveyWithPollsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSurvey && IsSurveyWithPollsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Forem.Survey, TResult>? survey = null,
            global::System.Func<global::Forem.SurveyWithPollsVariant2, TResult>? surveyWithPollsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSurvey && survey != null)
            {
                return survey(Survey!);
            }
            else if (IsSurveyWithPollsVariant2 && surveyWithPollsVariant2 != null)
            {
                return surveyWithPollsVariant2(SurveyWithPollsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Forem.Survey>? survey = null,

            global::System.Action<global::Forem.SurveyWithPollsVariant2>? surveyWithPollsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSurvey)
            {
                survey?.Invoke(Survey!);
            }
            else if (IsSurveyWithPollsVariant2)
            {
                surveyWithPollsVariant2?.Invoke(SurveyWithPollsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Forem.Survey>? survey = null,
            global::System.Action<global::Forem.SurveyWithPollsVariant2>? surveyWithPollsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSurvey)
            {
                survey?.Invoke(Survey!);
            }
            else if (IsSurveyWithPollsVariant2)
            {
                surveyWithPollsVariant2?.Invoke(SurveyWithPollsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Survey,
                typeof(global::Forem.Survey),
                SurveyWithPollsVariant2,
                typeof(global::Forem.SurveyWithPollsVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(SurveyWithPolls other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Forem.Survey?>.Default.Equals(Survey, other.Survey) &&
                global::System.Collections.Generic.EqualityComparer<global::Forem.SurveyWithPollsVariant2?>.Default.Equals(SurveyWithPollsVariant2, other.SurveyWithPollsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SurveyWithPolls obj1, SurveyWithPolls obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SurveyWithPolls>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SurveyWithPolls obj1, SurveyWithPolls obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SurveyWithPolls o && Equals(o);
        }
    }
}
