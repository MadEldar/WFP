using Microsoft_News.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_News
{
    public class Database
    {
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<News> News { get; set; } = new List<News>();

        public static Database DB = new Database();

        private Database()
        {
            Categories.Add(new Category() { Id = 1, Name = "World" });
            Categories.Add(new Category() { Id = 2, Name = "Business" });
            Categories.Add(new Category() { Id = 3, Name = "Science" });
            Categories.Add(new Category() { Id = 4, Name = "Opinion" });
            Categories.Add(new Category() { Id = 5, Name = "Good News" });
            Categories.Add(new Category() { Id = 6, Name = "Weather" });
            Categories.Add(new Category() { Id = 7, Name = "Money" });
            Categories.Add(new Category() { Id = 8, Name = "Crime" });
            Categories.Add(new Category() { Id = 9, Name = "Technology" });
            Categories.Add(new Category() { Id = 10, Name = "Sports" });

            var content = new List<NewsContent>();
            content.Add(new NewsContent()
            {
                Type = "text",
                Content = "Current and former U.S. officials have told Newsweek that China is the top counterintelligence risk to the United States, posing a unique and unprecedented threat spanning far beyond interference in the upcoming election, including the mass infiltration of the private communications networks of U.S. businesses and organizations that are not protected by governmental security networks."
            });
            content.Add(new NewsContent()
            {
                Type = "image",
                Content = "https://d.newsweek.com/en/full/1628388/china-pla-strategic-support-force.jpg?w=790&f=64aa7b25ec2f453960178f3f6d91c8dc"
            });
            content.Add(new NewsContent()
            {
                Type = "text",
                Content = "\"There is no country that presents a broader and more comprehensive threat to our ideas, innovation, and economic security than China\" the FBI told Newsweek in a statement. \"The threat takes many different forms, and it is the FBI's top counterintelligence priority.\""
            });
            content.Add(new NewsContent()
            {
                Type = "text",
                Content = "The Office of the Director of National Intelligence offered a similar analysis. \"China remains a top focus of the Counterintelligence community and has been for many years,\" the office said in a separate statement sent to Newsweek."
            });
            News.Add(new News() {
                Id = 1,
                Title = "China Poses Unprecedented Security Risk to US Far Beyond Elections",
                Thumbnail = "https://dc.newsweek.com/en/full/2032608/chinese-ambassador-liu-xiaoming-says-us-politicians-will-say-anything-get-elected.webp?w=790&h=444&f=0b94084c7831ddee18262834072f4ddf",
                Author = "Naveed Jamali",
                CategoryId = 1,
                Content = content
            });
            
            content = new List<NewsContent>();
            content.Add(new NewsContent()
            {
                Type = "text",
                Content = "The suspected poisoning of Russian opposition figure Alexei Navalny has parallels with an attack on a Bulgarian arms manufacturer involving the nerve agent that sickened an ex-FSB agent in the U.K., according to a report in the German media."
            });
            content.Add(new NewsContent()
            {
                Type = "text",
                Content = "Owner of the weapons maker EMCO Ltd, Emilian Gebrew, managed to survive after he collapsed and fell into a coma in April 2015. Although initially doctors could not determine the poison used, Gebrew saw similarities between his case and that of the March 2018 attack on Sergei Skripal and his daughter Yulia, in Salisbury, England."
            });
            content.Add(new NewsContent()
            {
                Type = "text",
                Content = "Journalists from the German magazine Der Spiegel and the investigative website Bellingcat, pieced together similarities between the poisonings of Gebrew and the Skripals, in which the deadly nerve agent novichok was used."
            });
            content.Add(new NewsContent()
            {
                Type = "image",
                Content = "https://d.newsweek.com/en/full/1628489/navalny-hospital.jpg?w=790&f=0c886ce64276cdcab789021b0466c2d4"
            });
            News.Add(new News() {
                Id = 2,
                Title = "Navalny Poisoning Similar to Novichok Attacks on Skripals: Report",
                Thumbnail = "https://dc.newsweek.com/en/full/2032950/alexei-navalny.webp?w=790&h=444&f=13f44552a93f73ae500138927268aab4",
                Author = "Brendan Cole",
                CategoryId = 1,
                Content = content
            });
            
            content = new List<NewsContent>();
            content.Add(new NewsContent()
            {
                Type = "text",
                Content = "Agroup of Iranian lawmakers is pushing to hand control of the country's internet over to a committee composed of powerful elements of the regime, including the Islamic Revolutionary Guards Corps."
            });
            content.Add(new NewsContent()
            {
                Type = "text",
                Content = "Forty members of the Iranian parliament had signed the motion as of Monday, according to Radio Farda. The proposal—titled \"Organizing Social Media Messaging,\" would also ban foreign messaging apps and replace them with domestically-produced ones, which may hand the regime closer surveillance capabilities."
            });
            content.Add(new NewsContent()
            {
                Type = "text",
                Content = "The legislation would also introduce new penalties for anyone offering foreign messaging apps or ways around the restrictions, for example VPNs. Those violating the new proposal will face a \"six degree\" imprisonment or fine, meaning anywhere from six months to two years in prison, and a fine of between $475 and $1,900."
            });
            content.Add(new NewsContent()
            {
                Type = "text",
                Content = "A \"domestic messaging app\" will mean more than 50 percent of the program's shares must be held by an Iranian citizen, it must be hosted in Iran, and its operations must abide by the country's laws."
            });
            News.Add(new News() {
                Id = 3,
                Title = "Iran Pushes for Regime, Military Control of Internet After Year of Unrest",
                Thumbnail = "https://d.newsweek.com/en/full/1628560/iran-parliament-internet-control-military-social-media.jpg?w=466&h=311&f=97e46f9e69aac08c9071c63b6a7384e7",
                Author = "David Brennan",
                CategoryId = 1,
                Content = content
            });
            
            content = new List<NewsContent>();
            content.Add(new NewsContent()
            {
                Type = "text",
                Content = "In a year where U.S.-China relations have been on a knife's edge, the most recent developments in the pair's relationship have shown how contradictory Trump administration messaging can be."
            });
            content.Add(new NewsContent()
            {
                Type = "text",
                Content = "This morning, reports emerged that U.S. and Chinese officials had reaffirmed their commitment to phase one of their joint trade deal in a call."
            });
            content.Add(new NewsContent()
            {
                Type = "text",
                Content = "The call, involving Trade Representative Robert Lighthizer, Treasury Secretary Steven Mnuchin and Chinese Vice Premier Liu He, is the first formal dialogue between the two sides since May."
            });
            content.Add(new NewsContent()
            {
                Type = "text",
                Content = "\"Both sides see progress and are committed to taking the steps necessary to ensure the success of the agreement,\" Mnuchin's office said in a statement after the call, which came six months on from an initial agreement and amid worsening diplomatic relations."
            });
            News.Add(new News() {
                Id = 4,
                Title = "Officials Keep U.S.-China Trade Deal Alive Despite \'Tantrum Diplomacy\'",
                Thumbnail = "https://dc.newsweek.com/en/full/2032769/tiktok.webp?w=790&h=444&f=f8cb03c725b124ab8092aecfb9a61491",
                Author = "Lucy Harley-McKeown",
                CategoryId = 2,
                Content = content
            });
            
            content = new List<NewsContent>();
            content.Add(new NewsContent()
            {
                Type = "text",
                Content = "As the \"unsurvivable\" hurricane Laura hits Louisiana, satellite images show the scale of the storm that is expected to cause \"catastrophic\" damage in multiple states."
            });
            content.Add(new NewsContent()
            {
                Type = "text",
                Content = "Data and visualization feeds maintained by scientists and meteorologists can be used to track the storm's speed, strength and direction, and there are multiple official sources of information that may prove useful to concerned citizens or weather-watchers."
            });
            content.Add(new NewsContent()
            {
                Type = "text",
                Content = "Areas in Cameron Parish, Louisiana, are now predicted to see surges of water that could reach between 15 and 20 feet high, one of the latest advisories said. More than 500,000 residents of Louisiana and Texas have been asked to evacuate their homes."
            });
            content.Add(new NewsContent()
            {
                Type = "image",
                Content = "https://pbs.twimg.com/media/EgXqvtiUcAALLpy?format=jpg&name=240x240"
            });
            News.Add(new News() {
                Id = 5,
                Title = "Track Hurricane Laura from Space as Satellite Images Show Scale of Storm",
                Thumbnail = "https://d.newsweek.com/en/full/1628558/nasa-satelitte-image-hurricane-laura.png?w=591&h=394&f=6ca579c9f32049e2384a2e627aa92441",
                Author = "Lucy Harley-McKeown",
                CategoryId = 3,
                Content = content
            });
        }
    }
}
