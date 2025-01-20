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


