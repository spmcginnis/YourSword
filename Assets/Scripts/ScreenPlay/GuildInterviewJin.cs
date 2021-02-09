using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public class GuildInterviewJin : ScreenPlay
    {
        public GuildInterviewJin()
        {
            this.Title = "Guild Interview with Jin.";   
            this.BackgroundImagePaths = new Dictionary<string, string>()
            {
                {"TestBackgroundName", "TestBackgroundURL"} //TEMP
            };
            this.CastOfCharacters = new List<string>() {
                margot, jin
            };

            this.Text = new List<Line>()
            {
                {new Line(
                    speaker:none,
                    commands: new List<string>() {changeBackground+"GuildInterviewBG"} //TEMP
                )},
                {new Line(
                    commands: new List<string>() {enter+margot,enter+jin}
                )},
                {new Line(
                    speaker: margot,
                    "Oh, sorry...you’re the one who wanted to apply for guild membership today, aren’t you? I wasn’t expecting you for a while.",
                    new List<string>() {pleasant+margot}
                )}, 
                {new Line(
                    speaker:jin,
                    storyText: "...apologies."
                )},
                {new Line(
                    speaker:margot,
                    storyText: "Well don’t just stand there lurking in the doorway. Come in."
                )},
                {new Line(
                    speaker:jin,
                    storyText: "Thanks."
                )},
                {new Line(
                    speaker:margot,
                    storyText: "Welcome to the Bobcat Guild. We’re pretty proud of our establishment here, even though it’s errr...humble. We take our jobs seriously and do our utmost to serve the city. Are you from around here? I haven’t seen your face before."
                )},
                {new Line(
                    speaker:jin,
                    storyText: "No. I’m not from around here."
                )},
                {new Line(
                    speaker:margot,
                    storyText: "Oh! Then what brings you to the city?"
                )},
                {new Line(
                    storyText: "It’s not exactly a place people move to. Or...visit.",
                    commands: new List<string>() {sarcastic+margot}
                )},
                {new Line(
                    storyText: "But we do have good theatre. Is it the theatre? The market isn’t bad, either. What was the draw?",
                    commands: new List<string>() {pleasant+margot}
                )},
                {new Line(
                    speaker:jin,
                    storyText: " ... the food.",
                    commands: new List<string>() {impassive+jin}
                )},
                {new Line(
                    speaker:margot,
                    storyText: "Of course, of course! Madame Belso’s bakery is famously divine! And when the fishing picks up, the blackened trout at Freshwater Filet is delish. Have you been?"
                )},
                {new Line(
                    speaker:jin,
                    storyText: "No. I’m very newly arrived. And interested in working. So I can hurry up and get eating."
                )},
                {new Line(
                    speaker:margot,
                    storyText: "Of course. Well, lucky for you, there’s plenty to be done. Horrible monsters everywhere...so let’s get you qualified, eh? What’s your specialty?"
                )},
                {new Line(
                    speaker:jin,
                    storyText: "Magic."
                )},
                {new Line(
                    speaker:margot,
                    storyText: "Oh, excellent. Always in need of people who’ve mastered magic."
                )},
                {new Line(
                    storyText: "If you don’t mind. I’d like to take a look around that head of yours, to take stock of your abilities. My own magical specialty is assessment and identification--so it’s a very quick and simple procedure that will allow me to extract all the data I need. It will help us figure out how you fit in with the guild, and what jobs you’ll be best suited for."
                )},
                {new Line(
                    speaker:jin,
                    storyText: "I’m familiar with the procedure.  I don’t think it’s a good idea.",
                    commands: new List<string>() {grouchy+jin}
                )},
                {new Line(
                    speaker:margot,
                    storyText: "Rest assured I cannot read your mind, manipulate you, or do anything of the sort. If I could, I promise you I would be by the seaside surrounded by handsome servants, drinking plum rum,"
                )},
                {new Line(
                    storyText: "not working as a clerk in broke adventurers' guild drinking watered down tea.",
                    commands: new List<string>() {continued, disgusted+margot}
                )},
                {new Line(
                    speaker:jin,
                    storyText: "There’s no need for you to magically assess me. I’m quite open to showing you the breadth of my capabilities. I have a portfolio prepared…",
                    commands: new List<string>() {pleasant+margot, smug+jin}
                )},
                {new Line(
                    speaker:margot,
                    storyText: "Look, Mr. … what was your name?",
                    commands: new List<string>() {grouchy+margot}
                )},
                {new Line(
                    speaker:jin,
                    storyText: "... Jin"
                )},
                {new Line(
                    speaker:margot,
                    storyText: "Oh, you go by one name, that’s super surprising. Look, I know your type. You walk here all smug and trying to be mysterious and...edgy or whatever, and no matter how inviting I am, and you don’t want to give me any information about yourself, even though it’s literally my job to get information about you."
                )},
                {new Line(
                    speaker:jin,
                    storyText: "... my portfolio ..."
                )},
                {new Line(
                    speaker:margot,
                    storyText: "You will take the next hour showing me 60% of what you can do, because 40% of what you can do is either too dangerous or impossible to demonstrate. When I can simply evaluate you magically and know, in about 15 seconds, everything you have to offer, not just magically, but intellectually and athletically ..."
                )},
                {new Line(
                    storyText: "... and either way, I’ve got to spend about three hours writing up your file, so please, let a girl save herself some time."
                )},
                {new Line(
                    speaker:jin,
                    storyText: "... it's not a good idea.",
                    commands: new List<string>() {impassive+jin}
                )},
                {new Line(
                    speaker:margot,
                    storyText: "..."
                )},
                {new Line(
                    storyText: "... Mr. Jin ..."
                )},
                {new Line(
                    speaker:jin,
                    storyText: "..."
                )},
                {new Line(
                    storyText: "Fine."
                )},
                {new Line(
                    speaker:narrator,
                    storyText: "[[She does the thing...]]" // TEMP
                )},
                {new Line(
                    speaker:margot,
                    storyText: "You ... what the ... what the hell is going on with you?",
                    commands: new List<string>() {startled+margot}
                )},
                {new Line(
                    speaker:jin,
                    storyText: "I tried to tell you."
                )},
                {new Line(
                    speaker:margot,
                    storyText: "You did not. You said it wasn’t a good idea. You didn’t say...what kind of...weird...",
                    commands: new List<string>() {angry+margot}
                )},
                {new Line(
                    speaker:jin,
                    storyText: "I did. Try to tell you. You should listen to people."
                )},
                {new Line(
                    speaker:margot,
                    storyText: "I should, now? Mr. Jin, that was...that was not... [she pulls it together and realizes she’s mad]" // TEMP
                )},
                {new Line(
                    storyText: "Where is all that...energy coming from?!",
                    commands: new List<string>() {impassive+margot}
                )},
                {new Line(
                    speaker:jin,
                    storyText: "I’m just blessed, Miss ... ?"
                )},
                {new Line(
                    speaker:margot,
                    storyText: "Finlay.  But you can call me Margot.  I have two names.",
                    commands: new List<string>() {sarcastic+margot}
                )},
                {new Line(
                    speaker:jin,
                    storyText: "Nice to meet you.",
                    commands: new List<string>() {smirk+jin}
                )},
                {new Line(
                    speaker:margot,
                    storyText: "Same."
                )},
                {new Line(
                    speaker:jin,
                    storyText: "Are you alright?"
                )},
                {new Line(
                    speaker:margot,
                    storyText: "I am perfectly fine.",
                    commands: new List<string>() {blush+margot}
                )},
                {new Line(
                    storyText: "... of course, you’re not. ",
                    commands: new List<string>() {continued}
                )},
                {new Line(
                    speaker:jin,
                    storyText: "I have no idea what you mean by that."
                )},
                {new Line(
                    speaker:margot,
                    storyText: "...Anyway, I’m sure you already know you’re more than qualified, and suited for high-level missions, if that’s what you choose to do. You might get rich enough to eat whatever your heart desires, Mr. Jin. "
                )},
                {new Line(
                    storyText: "...Though I doubt that’s what you’re really interested in."
                )},
                {new Line(
                    speaker:jin,
                    storyText: "I'm interested in many things."
                )},
                {new Line(
                    speaker:margot,
                    storyText: "I’m sure. I’ll make your file, and you should be cleared to start tomorrow, if you wish. ",
                    commands: new List<string>() {sarcastic+margot}
                )},
                {new Line(
                    speaker:none,
                    commands: new List<string>() {changeBackground+"MCinGuild"} //TEMP //TODO refactor out magic strings
                )},
                {new Line(
                    speaker:margot,
                    storyText: "Hello, there, Mr. Jin. Something on your mind?"
                )},
                {new Line(
                    speaker:jin,
                    storyText: "... no."
                )},
                {new Line(
                    speaker:margot,
                    storyText: "I see..Well, if you’re wondering about the lady, save your big brain the time. She’s trouble."
                )},
                {new Line(
                    speaker:jin,
                    storyText: "Is she now?"
                )},
                {new Line(
                    speaker:margot,
                    storyText: "She’s from the thieves guild. Pretty sure she runs the show over there actually. She’s no friend of mine, but she comes from time to time to...meet with Anders. He’s the brass here."
                )},
                {new Line(
                    storyText: "... Apparently they have some kind of understanding."
                )},
                {new Line(
                    speaker:narrator,
                    storyText: "[CutScene: MC turns and looks toward them, her eyes still obscured. She smiles without her teeth.]"
                )},
                {new Line(
                    speaker:none,
                    commands: new List<string>() {changeBackground+"GuildInterviewBG"} //TEMP
                )},
                {new Line(
                    speaker:margot,
                    storyText: "She’s about like you, I’d imagine. Well, not quite like you. But you know. A mysterious pain-in-the-butt."
                )},
                {new Line(
                    speaker:jin,
                    storyText: "I don’t know this thief, but I suppose that’s a fair enough assessment of me.",
                    commands: new List<string>() {smirk+jin}
                )},
                {new Line(
                    speaker:margot,
                    storyText: "Yeah.  But unlike her, you’re not all bad, even though you’re annoying. Because if you were, there’s no way I’d approve your application."
                )},
                {new Line(
                    speaker:jin,
                    storyText: "Why is that?"
                )},
                {new Line(
                    speaker:margot,
                    storyText: "Don’t think i’m so overwhelmed by your abilities that I couldn’t tell you’ve got something “walled off”--from magical prying eyes."
                )},
                {new Line(
                    speaker:jin,
                    storyText: "..."
                )},
                {new Line(
                    speaker:margot,
                    storyText: "Oh, don’t worry, it’s a very good wall. Couldn’t see past it."
                )},
                {new Line(
                    storyText: "But there are only a handful of reasons that applicants do that.",
                    commands: new List<string>() {continued, skeptical+margot}
                )},
                {new Line(
                    speaker:jin,
                    storyText: "And you let them join?"
                )},
                {new Line(
                    speaker:margot,
                    storyText: "Sometimes. But don’t think for a second that I don’t know what a monster looks like."
                )},
                {new Line(
                    storyText: "This is Timbervale, dummy.",
                    commands: new List<string>() {pleasant+margot}
                )},
                {new Line(
                    speaker:none,
                    commands: new List<string>() {endChapter}
                )}
            };
        }
    }
}
