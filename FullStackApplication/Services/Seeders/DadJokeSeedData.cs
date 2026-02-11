using System;
using FullStackApplication.Models.Entities;

namespace FullStackApplication.Services.Seeders;

public static class DadJokeSeedData
{
    public static IEnumerable<DadJoke> GenerateDadJokes()
    {
        var i = 1;

        yield return new DadJoke { Id = NextId(), Joke = "I used to hate facial hair, but then it grew on me." };
        yield return new DadJoke { Id = NextId(), Joke = "Why don’t eggs tell jokes? They’d crack each other up." };
        yield return new DadJoke { Id = NextId(), Joke = "I only know 25 letters of the alphabet. I don’t know y." };
        yield return new DadJoke { Id = NextId(), Joke = "What do you call fake spaghetti? An impasta." };
        yield return new DadJoke { Id = NextId(), Joke = "Why did the scarecrow win an award? Because he was outstanding in his field." };
        yield return new DadJoke { Id = NextId(), Joke = "I told my wife she was drawing her eyebrows too high. She looked surprised." };
        yield return new DadJoke { Id = NextId(), Joke = "Why don’t skeletons fight each other? They don’t have the guts." };
        yield return new DadJoke { Id = NextId(), Joke = "I’m reading a book on anti-gravity. It’s impossible to put down." };
        yield return new DadJoke { Id = NextId(), Joke = "Did you hear about the restaurant on the moon? Great food, no atmosphere." };
        yield return new DadJoke { Id = NextId(), Joke = "I would tell you a joke about construction, but I’m still working on it." };

        // Food
        yield return new DadJoke { Id = NextId(), Joke = "Why did the tomato blush? Because it saw the salad dressing." };
        yield return new DadJoke { Id = NextId(), Joke = "I burned 2,000 calories today. I left my pizza in the oven too long." };
        yield return new DadJoke { Id = NextId(), Joke = "Why don’t eggs ever win arguments? They always crack under pressure." };
        yield return new DadJoke { Id = NextId(), Joke = "I asked the waiter for a joke. He said the steak was a rare medium well done." };
        yield return new DadJoke { Id = NextId(), Joke = "What kind of cheese do you use to disguise a horse? Mascarpone." };

        // Work / office
        yield return new DadJoke { Id = NextId(), Joke = "I told my boss I needed a raise because of inflation. He said, 'You’re already full of hot air.'" };
        yield return new DadJoke { Id = NextId(), Joke = "Why did the developer go broke? Because he used up all his cache." };
        yield return new DadJoke { Id = NextId(), Joke = "I love deadlines. I like the whooshing sound they make as they fly by." };
        yield return new DadJoke { Id = NextId(), Joke = "Why did the computer catch a cold? It forgot to close its Windows." };
        yield return new DadJoke { Id = NextId(), Joke = "My computer sings sometimes. It’s a Dell." };

        // Animals
        yield return new DadJoke { Id = NextId(), Joke = "Why don’t oysters donate to charity? Because they are shellfish." };
        yield return new DadJoke { Id = NextId(), Joke = "What do you call a fish wearing a bowtie? Sofishticated." };
        yield return new DadJoke { Id = NextId(), Joke = "Why did the cow get promoted? Because he was outstanding in his field." };
        yield return new DadJoke { Id = NextId(), Joke = "Why don’t cats play poker in the jungle? Too many cheetahs." };
        yield return new DadJoke { Id = NextId(), Joke = "What do you call a sleeping bull? A bulldozer." };

        // Science / nerdy
        yield return new DadJoke { Id = NextId(), Joke = "Why can’t you trust atoms? They make up everything." };
        yield return new DadJoke { Id = NextId(), Joke = "Schrödinger’s cat walks into a bar. And doesn’t." };
        yield return new DadJoke { Id = NextId(), Joke = "Why did the math book look sad? It had too many problems." };
        yield return new DadJoke { Id = NextId(), Joke = "Parallel lines have so much in common. It’s a shame they’ll never meet." };
        yield return new DadJoke { Id = NextId(), Joke = "Why was six afraid of seven? Because seven eight nine." };

        // Family / life
        yield return new DadJoke { Id = NextId(), Joke = "I asked my dog what’s two minus two. He said nothing." };
        yield return new DadJoke { Id = NextId(), Joke = "I told my kids I was a joke machine. They said my output was low quality." };
        yield return new DadJoke { Id = NextId(), Joke = "I started a band called 1023MB. We haven’t gotten a gig yet." };
        yield return new DadJoke { Id = NextId(), Joke = "I told my wife I’d fix the squeaky door. I added it to my to-do list from 2019." };
        yield return new DadJoke { Id = NextId(), Joke = "Why did the bicycle fall over? Because it was two-tired." };

        // Wordplay / misc
        yield return new DadJoke { Id = NextId(), Joke = "I used to be addicted to soap, but I’m clean now." };
        yield return new DadJoke { Id = NextId(), Joke = "I’m on a seafood diet. I see food and I eat it." };
        yield return new DadJoke { Id = NextId(), Joke = "I tried to catch fog yesterday. Mist." };
        yield return new DadJoke { Id = NextId(), Joke = "Why did the picture go to jail? Because it was framed." };
        yield return new DadJoke { Id = NextId(), Joke = "I told a joke about time travel, but you didn’t like it." };

        // Extra semantic fillers
        yield return new DadJoke { Id = NextId(), Joke = "I bought shoes from a drug dealer. I don’t know what he laced them with." };
        yield return new DadJoke { Id = NextId(), Joke = "Why did the golfer bring two pairs of pants? In case he got a hole in one." };
        yield return new DadJoke { Id = NextId(), Joke = "Why did the orange stop rolling? It ran out of juice." };
        yield return new DadJoke { Id = NextId(), Joke = "Why did the stadium get hot after the game? All the fans left." };
        yield return new DadJoke { Id = NextId(), Joke = "Why did the scarecrow get promoted? He was outstanding in his field." };
           // More work / tech
        yield return new DadJoke { Id = NextId(), Joke = "Why do programmers prefer dark mode? Because light attracts bugs." };
        yield return new DadJoke { Id = NextId(), Joke = "I changed my password to 'incorrect'. Now it reminds me when I forget it." };
        yield return new DadJoke { Id = NextId(), Joke = "Why did the database administrator leave his wife? She had too many relations." };
        yield return new DadJoke { Id = NextId(), Joke = "I told my computer I needed a break, and it froze." };
        yield return new DadJoke { Id = NextId(), Joke = "Why did the spreadsheet break up with the calculator? It felt used." };

        // Sports
        yield return new DadJoke { Id = NextId(), Joke = "Why did the golfer bring extra socks? In case he got a hole in one." };
        yield return new DadJoke { Id = NextId(), Joke = "Why was the baseball stadium so cool? It was full of fans." };
        yield return new DadJoke { Id = NextId(), Joke = "I tried playing soccer, but I kept kicking up old habits." };
        yield return new DadJoke { Id = NextId(), Joke = "Why don’t runners ever get lost? They always follow the track." };
        yield return new DadJoke { Id = NextId(), Joke = "I wanted to be a professional skateboarder, but I couldn’t handle the boards." };

        // Money / finance
        yield return new DadJoke { Id = NextId(), Joke = "Why did the banker switch careers? He lost interest." };
        yield return new DadJoke { Id = NextId(), Joke = "I tried to save money by using a calendar. It had too many dates." };
        yield return new DadJoke { Id = NextId(), Joke = "Why was the credit card feeling insecure? It was constantly being declined." };
        yield return new DadJoke { Id = NextId(), Joke = "I opened a bakery for rich people. All they wanted was dough." };
        yield return new DadJoke { Id = NextId(), Joke = "Why did the accountant cross the road? To balance the books." };

        // Travel / transport
        yield return new DadJoke { Id = NextId(), Joke = "Why don’t elevators tell jokes? They’re always letting people down." };
        yield return new DadJoke { Id = NextId(), Joke = "I tried to catch a taxi, but it kept taking me for a ride." };
        yield return new DadJoke { Id = NextId(), Joke = "Why did the bicycle stop working? It was tired of being pushed around." };
        yield return new DadJoke { Id = NextId(), Joke = "I once got fired from the calendar factory. I took too many days off." };
        yield return new DadJoke { Id = NextId(), Joke = "Why did the train get promoted? It had a great track record." };

        // Home / DIY
        yield return new DadJoke { Id = NextId(), Joke = "I tried fixing the broken fan, but I wasn’t a big fan of it." };
        yield return new DadJoke { Id = NextId(), Joke = "Why did the hammer get a promotion? It really nailed the job." };
        yield return new DadJoke { Id = NextId(), Joke = "I told my toolbox a joke. It couldn’t handle it." };
        yield return new DadJoke { Id = NextId(), Joke = "Why did the light bulb fail its exam? It wasn’t too bright." };
        yield return new DadJoke { Id = NextId(), Joke = "I tried gardening, but I just couldn’t dig it." };

        // Language / meta humor (great for embeddings)
        yield return new DadJoke { Id = NextId(), Joke = "I once told a joke about grammar, but it lacked proper punctuation." };
        yield return new DadJoke { Id = NextId(), Joke = "I made a joke about synonyms, but it didn’t land. Or arrive. Or touch down." };
        yield return new DadJoke { Id = NextId(), Joke = "I tried writing a joke about metaphors, but it went over my head." };
        yield return new DadJoke { Id = NextId(), Joke = "Why was the sentence afraid of the comma? It was being judged." };
        yield return new DadJoke { Id = NextId(), Joke = "I told a joke about semantics. You probably understood it differently." };
        yield break;

        string NextId() => $"dadjoke-{i++:D3}";
    }
}