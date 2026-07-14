public class PromptGenerator
{
    public List<string> _prompts = new List<string> {"Who was the most interesting person I interacted with today?","What was the best part of my day?","How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?","If I had one thing I could do over today, what would it be?"};
    public string GetRandomPrompt()
    {
        List<string> prompts = _prompts;
        int length = prompts.Count;
        Random rand = new Random();
        int randomNumber = rand.Next(1, length);
        int randomIndex = randomNumber - 1;
        return $"{prompts[randomIndex]}";
    }
}