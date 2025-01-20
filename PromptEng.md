Prompt engineering is the process of crafting clear instructions to guide AI systems, like GitHub Copilot, to generate context-appropriate code tailored to your project's specific needs. This ensures the code is syntactically, functionally, and contextually correct.

## Principles of prompt engineering

- **Single**: Always focus your prompt on a single, well-defined task or question. This clarity is crucial for eliciting accurate and useful responses from Copilot.
- **Specific**: Ensure that your instructions are explicit and detailed. Specificity leads to more applicable and precise code suggestions.
- **Short**: While being specific, keep prompts concise and to the point. This balance ensures clarity without overloading Copilot or complicating the interaction.
- **Surround**: Utilize descriptive filenames and keep related files open. This provides Copilot with rich context, leading to more tailored code suggestions.

By adding some comments at the top of your code to give more details to what you want, you can give more context to Copilot to understand your prompt, and provide better code suggestions.

![context example](https://github.com/codess-aus/GitHub-Copilot-Certification/blob/799ac0f6224a736a02b9ebee0021021d727aeebf/images/context.gif)

In the example above, we used steps to give more detail while keeping it short. This practice follows the 'Short' principle, balancing detail with conciseness to ensure clarity and precision in communication.

***Copilot also uses parallel open tabs in your code editor to get more context on the requirements of your code.***

Using examples can clarify your requirements and expectations, illustrating abstract concepts and making the prompts more tangible for Copilot.

![Example esample](https://github.com/codess-aus/GitHub-Copilot-Certification/blob/2ea2c5ec23f586c6c13bde62d8a63f84e81899ea/images/examples.gif)

## Iteration. 

Your first prompt might not always yield the perfect code. If the first output isn't quite what you're looking for, treat it as a step in a dialogue. Erase the suggested code, enrich your initial comment with added details and examples, and prompt Copilot again.

GitHub Copilot operates based on AI models trained on vast amounts of data. To enhance its understanding of specific code contexts, engineers often provide it with examples.

## Zero-shot learning
GitHub Copilot generates code **without any specific examples**, relying solely on its foundational training. 

![zero shot example](https://github.com/codess-aus/GitHub-Copilot-Certification/blob/2db7fa3b1e34e0eb54bb334d1e7199d2b0ebe80f/images/zeroshot.png)

## One-shot learning
A single example is given, aiding the model in generating a more context-aware response. 

![one shot example](https://github.com/codess-aus/GitHub-Copilot-Certification/blob/2db7fa3b1e34e0eb54bb334d1e7199d2b0ebe80f/images/oneshot.png)

## Few-shot learning

Copilot is presented with several examples, which strike a balance between zero-shot unpredictability and the precision of fine-tuning. 

Let's say you want to generate code that sends you a greeting depending on the time of the day. Here's a few-shot version of that prompt:

![Few Shot example](https://github.com/codess-aus/GitHub-Copilot-Certification/blob/2db7fa3b1e34e0eb54bb334d1e7199d2b0ebe80f/images/fewshot.png)

## How Copilot collects context details

- Code before and after the cursor position, which helps it understand the immediate context of the prompt.
- Filename and type of the file being edited, allowing it to tailor code suggestions to the specific file type.
- Information about adjacent open tabs, ensuring that the generated code aligns with other code segments in the same project.
- Information on project structure and file paths
- Information on programming languages and frameworks
- Pre-processing using Fill-in-the-Middle (FIM) technique to consider both the preceding and following code context, effectively expanding the model's understanding allowing Copilot to generate more accurate and relevant code suggestions by leveraging a broader context.

## Proxy filter

Once the context is gathered and the prompt is built, it passes securely to a proxy server hosted in a GitHub-owned Microsoft Azure tenant. The proxy filters traffic, blocking attempts to hack the prompt or manipulate the system into revealing details about how the model generates code suggestions.

## Toxicity filtering

Copilot incorporates content filtering mechanisms before proceeding with intent extraction and code generation, to ensure that the generated code and responses don't include or promote:

- **Hate speech and inappropriate content**: Copilot employs algorithms to detect and prevent the intake of hate speech, offensive language, or inappropriate content that could be harmful or offensive.
- **Personal data**: Copilot actively filters out any personal data, such as names, addresses, or identification numbers, to protect user privacy and data security.

## Post-processing and response validation

- **Code quality**: Responses are checked for common bugs or vulnerabilities, such as cross-site scripting (XSS) or SQL injection, ensuring that the generated code is robust and secure.
- **Matching public code (optional)**: Optionally, administrators can enable a filter that prevents Copilot from returning suggestions over ~150 characters if they closely resemble existing public code on GitHub. This prevents coincidental matches from being suggested as original content. If any part of the response fails these checks, it is either truncated or discarded.

## Suggestion delivery and feedback loop initiation
Only responses that pass all filters are delivered to the user. Copilot then initiates a feedback loop based on your actions to achieve the following:

- Grow its knowledge from accepted suggestions.
- Learn and improve through modifications and rejections of its suggestions.

The process is repeated as you provide more prompts, with Copilot continuously handling user requests, understanding their intent, and generating code in response. Over time, Copilot applies the cumulative feedback and interaction data, including context details, to improve its understanding of user intent and refine its code generation capabilities.

