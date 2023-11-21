public class Prompt
{

    private static string[] _promptList = {
        "What were three things you liked about your day today",
        "How did you better today than yesterday?",
        "What would you do differently today if you could?",
        "If your future self was a good freind how would you help them right now?",
        "What made you happy today? What did you do to make someone else happy?",
        "How have you made someone else's life better today?",
        "What are you proud about not doing today?"
    };
    private static List<string> _prompts = new List<string> (_promptList);
    


    public static string GetRandomPrompt()
    {
       int listRange =  _prompts.Count();
       Random randomNumber = new Random();
       int randomPrompt = randomNumber.Next(1, listRange);

        return _prompts[randomPrompt];
    }


}