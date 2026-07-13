
#nullable enable

namespace Forem
{
    /// <summary>
    /// Tool that produced the session (e.g. claude_code, codex).
    /// </summary>
    public enum CreateAgentSessionRequestToolName
    {
        /// <summary>
        /// 
        /// </summary>
        ClaudeCode,
        /// <summary>
        /// 
        /// </summary>
        Codex,
        /// <summary>
        /// 
        /// </summary>
        GeminiCli,
        /// <summary>
        /// 
        /// </summary>
        GithubCopilot,
        /// <summary>
        /// 
        /// </summary>
        Opencode,
        /// <summary>
        /// 
        /// </summary>
        Pi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAgentSessionRequestToolNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentSessionRequestToolName value)
        {
            return value switch
            {
                CreateAgentSessionRequestToolName.ClaudeCode => "claude_code",
                CreateAgentSessionRequestToolName.Codex => "codex",
                CreateAgentSessionRequestToolName.GeminiCli => "gemini_cli",
                CreateAgentSessionRequestToolName.GithubCopilot => "github_copilot",
                CreateAgentSessionRequestToolName.Opencode => "opencode",
                CreateAgentSessionRequestToolName.Pi => "pi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentSessionRequestToolName? ToEnum(string value)
        {
            return value switch
            {
                "claude_code" => CreateAgentSessionRequestToolName.ClaudeCode,
                "codex" => CreateAgentSessionRequestToolName.Codex,
                "gemini_cli" => CreateAgentSessionRequestToolName.GeminiCli,
                "github_copilot" => CreateAgentSessionRequestToolName.GithubCopilot,
                "opencode" => CreateAgentSessionRequestToolName.Opencode,
                "pi" => CreateAgentSessionRequestToolName.Pi,
                _ => null,
            };
        }
    }
}