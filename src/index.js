const core = require('@actions/core');
const github = require('@actions/github');

async function run() {
  try {
    const token = core.getInput('token');
    const branch = core.getInput('branch');
    const title = core.getInput('title');
    const body = core.getInput('body');

    const octokit = github.getOctokit(token);
    const { owner, repo } = github.context.repo;

    const { data: pullRequest } = await octokit.rest.pulls.create({
      owner,
      repo,
      title,
      head: branch,
      base: 'main',
      body
    });

    core.setOutput('pull-request-url', pullRequest.html_url);
  } catch (error) {
    core.setFailed(error.message);
  }
}

run();
