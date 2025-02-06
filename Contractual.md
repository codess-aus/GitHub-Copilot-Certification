# Contractual Protections

- **IP indemnity**: The GitHub Copilot Business and Enterprise plans include IP indemnity, which provides legal protection against intellectual property claims related to the use of Copilot suggestions. With IP indemnity, if any suggestion from GitHub Copilot is challenged as infringing on third-party IP rights, GitHub assumes legal responsibility. For GitHub to assume legal responsibility, the Matching public code setting must be blocked.
- **Data Protection Agreement (DPA)**: GitHub offers a DPA that outlines the measures taken to protect your data and ensure compliance with data privacy regulations. These agreements provide transparency and assurance that your data is handled securely and responsibly.
- **GitHub Copilot Trust Center**: The GitHub Copilot Trust Center provides detailed information about how GitHub Copilot works, including security, privacy, compliance, and intellectual property safeguards. This resource helps organizations feel confident using GitHub Copilot while adhering to best practices and legal requirements.

## Filtering out matching public code
GitHub Copilot can help minimize potential code overlap by identifying and filtering out code suggestions that match publicly available code. This feature is essential for maintaining the originality and security of your codebase. It can reduce the risk of incorporating nonsecure or noncompliant code into your projects.

## Manage content exclusions
The content exclusion feature in GitHub Copilot helps protect sensitive information by preventing the use of specific files, directories, or repositories to inform code-completion suggestions.

- Enabling content exclusions from repositories and organizations.
- Analyzing the impact of content exclusions on generated code suggestions.
- Identifying scenarios where content exclusions might not be fully effective.

## Impact of content exclusion on code suggestions
You can use content exclusions to configure GitHub Copilot to ignore certain files. When you exclude content from GitHub Copilot:

- Code completion is no longer available in the affected files.
- The content in affected files won't inform code completion suggestions in other files.
- The content in affected files won't inform GitHub Copilot Chat responses.

When you exclude certain files or directories, GitHub Copilot won't use the content in those files to inform its suggestions. This action can lead to more secure and compliant code suggestions, but it might also reduce the overall context available to GitHub Copilot. This reduction could potentially affect the accuracy and usefulness of the suggestions.

For example, excluding a critical configuration file might prevent Copilot from suggesting relevant code snippets that depend on the configurations defined in that file. It's essential to carefully analyze which files should be excluded to balance security and functionality.

