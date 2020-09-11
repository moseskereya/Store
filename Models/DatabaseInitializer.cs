using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Store.Models
{
    public class DatabaseInitializer: DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            getProducts().ForEach(c => context.Products.Add(c));
            getCategories().ForEach(p => context.Categories.Add(p));
        }

            protected static List<Category> getCategories()
            {
                var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Movies",
                    Description = "This is a list of movie and realted thing about entertainament"
                },
                 new Category
                 {
                    CategoryID = 2,
                    CategoryName = "Crafts",
                    Description = "These are collections of crafts made by diffent developers from all around the world"
                 }, 
                 new Category
                 {
                     CategoryID = 3,
                     CategoryName = "Recipes",
                     Description = "Some nice Recipes from our nice cooking stuff"
                 }
            };
                return categories;
            }
        protected static List<Product> getProducts()
        {
            var products = new List<Product>
            {
                 new Product
                {
                    ProductID = 1,
                    ProductName = "Angel Has Fallen",
                    Description = "The Has Fallen series feels like it's getting a little long in the tooth. I'm not sure anybody was expecting we'd get a second one of these, much less a third. And yet, here we are in 2019, with Angel Has Fallen. The movie brings back Gerard Butler as the Secret Service agent who's got John McClane's luck of always being in the wrong place at the wrong time. This time, he's suspected of attempting to kill the President of the Unites Stares, so instead of going after the bad guy, he's on the run himself",
                    ImagePath = "https://image.tmdb.org/t/p/original/4dwmJwyc1r55wTbHDDkyOhDPHII.jpg",
                    UnitPrice = 456.46,
                    CategoryID = 1,
                    Rating = 8.80M
                },

                new Product
                {
                    ProductID = 2,
                    ProductName = "Cold Pursuit",
                    Description = "Ever since Liam Neeson brought his particular set of skills to the big screen in Taken he launched a second career for himself, and several other older actors, as the elder statesmen of the action movie. Cold Pursuit sees Neeson as a mild mannered man who gets pushed over the edge when his son dies under mysterious circumstances. Determined to punish those responsible, he takes the fight to them himself.",
                    ImagePath = "https://images6.alphacoders.com/101/1017596.jpg",
                    UnitPrice = 673.45,
                    CategoryID = 1,
                    Rating = 7.77M
                },

                new Product
                {
                    ProductID = 3,
                    ProductName = "Avengers Endgame ",
                    Description = "Avengers: Endgame is a 2019 American superhero film based on the Marvel Comics superhero team the Avengers, produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures.It is the direct sequel to Avengers: Infinity War (2018) and the 22nd film in the Marvel Cinematic Universe (MCU). It was directed by Anthony and Joe Russo and written by Christopher Markus and Stephen ",
                    ImagePath = "https://th.bing.com/th/id/OIP.dPRA6GXVm8gnpVaNj8uR_gHaEZ?w=324&h=192&c=7&o=5&pid=1.7",
                    UnitPrice = 452.45,
                    CategoryID = 1,
                    Rating = 3.67M
                },



                new Product
                {
                    ProductID = 4,
                    ProductName = "Triple Frontier",
                    Description = "Triple Frontier is one of the better action movies we saw in 2019 that nobody ever had the chance to enjoy on the big screen outside of limited engagements. It was a film released exclusively on Netflix, but even on the smaller screen, it's worth checking out. It has an amazing cast that includes Ben Affleck, Oscar Isaac and Pedro Pascal, and while the film may not break much new ground, it succeeds at everything it tries to do, including putting forth some solid action sequences.",
                    ImagePath = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/charlie-hunnam-triple-frontier-1552466989.jpg?crop=1.00xw:0.504xh;0,0.146xh&resize=1200:*",
                    UnitPrice = 356.45,
                    CategoryID = 1,
                    Rating = 4.34M
                },



                new Product
                {
                    ProductID = 5,
                    ProductName = " Underground",
                    Description = "Like Roland Emmerich, if Michael Bay has a new movie out, then it's something that you need to see, and one should not let the fact that all the action takes place on a small screen detract from that fact. The newest movie on the list, 6 Underground, just came out on Netflix this month, and it sees Ryan Reynolds as a billionaire determined to make the world a better place by putting together an elite team of mercenaries and killing a whole bunch of (very bad) dudes.",
                    ImagePath = "https://img.cinemablend.com/filter:scale/quill/5/8/8/0/0/f/58800f64f45b9cbb8f504667f55f3664e8693d95.jpg?mw=600",
                    UnitPrice = 344.6,
                    CategoryID = 1,
                    Rating = 2.22M
                },



                new Product
                {
                    ProductID = 6,
                    ProductName = "Fast & Furious",
                    Description = "If the day ever comes when a Fast & Furious movie comes out and doesn't make a list like this, something has gone terribly wrong. While the first franchise spinoff, Hobbs and Shaw, is a significantly different movie than the main franchise's installments, it still brings top notch action, and has the incomparable action director David Leitch making sure that that action works.",
                    ImagePath = "http://image.tmdb.org/t/p/original/vVGSTbTx7DFJykP3bEgpjR3G85t.jpg",
                    UnitPrice = 560.88,
                    CategoryID = 1,
                    Rating = 9.10M
                },



                new Product
                {
                    ProductID = 7,
                    ProductName = "Dark Fate",
                    Description = "How in the hell did 2019 become the year we got a good Godzilla movie and a good Terminator movie, and nobody cared about either one? Although, to be fair, it's not like the Terminator franchise didn't have several bites at that apple in the past and basically failed every single time, However, Terminator: Dark Fate was the Terminator movie everybody had been waiting for. Arnold was back.Linda Hamilton was back.They both got to kick ass.And Mackenzie Davis is welcome to join Vanessa Kirby in the female action movie I've started to create in my head. This was the first Terminator movie in a long time to feel like a worthy part of the franchise. If you missed it, go fix that",
                    ImagePath = "https://media.comicbook.com/2019/11/terminator-dark-fate-1194056-1280x0.jpeg",
                    UnitPrice = 362.45,
                    CategoryID = 1,
                    Rating = 7.43M
                },

                new Product
                {
                    ProductID = 8,
                    ProductName = "Battle Angel",
                    Description = "Man, somehow, this list has become really depressing all of a sudden. Alita: Battle Angel wasn't a sequel nobody cared about, but it was a long gestating dream project for James Cameron that finally became a real thing thanks to Robert Rodriguez... that also not enough people saw. I was utterly shocked at how much I enjoyed Alita: Battle Angel. It's too bad the chances of an Alita sequel being made seem slim, for now.",
                    ImagePath = "http://images6.fanpop.com/image/photos/42100000/Alita-Battle-Angel-2019-alita-battle-angel-42100132-1777-938.jpg",
                    UnitPrice = 697.45,
                    CategoryID = 1,
                    Rating = 9.12M
                },

                new Product
                {
                    ProductID = 9,
                    ProductName = "King Of The Monsters",
                    Description = "And then, sometimes, you want your action in the form of giant monsters beating the crap out of each other. 2014's Godzilla was a generally well received movie, but if the film had any faults, it's that the giant monster action was a bit lacking. Godzilla: King of the Monsters clearly heard that critique, because a lack of action is not a problem here. In addition to Godzilla we got a bunch of new Titans in the sequel, and they all get to beat the hell out of each other",
                    ImagePath = "https://image.tmdb.org/t/p/original/hPLeAEr93ZA5uXYsN51VJQfR9c9.jpg",
                    UnitPrice = 442.45,
                    CategoryID = 1,
                    Rating = 5.16M
                },



                new Product
                {
                    ProductID = 10,
                    ProductName = "John Wick",
                    Description = "At some point, the John Wick series might start to falter, but if it keeps finding new ways to expand the universe and make action sequences feel fresh, like the addition of Halle Berry and her trained attack dogs, then this franchise will continue to be the top of the action genre for a long time to come. We can't wait until John Wick: Chapter 4, Was... was there really any chance in hell it was anything else? If a John Wick movie ever comes out and it's not at the top of a list like this, it's either a really good sign for action cinema, or a really bad sign for John Wick. Keanu Reeves returned for a third installment of the killer franchise with John Wick: Chapter 3 - Parabellum, and he hasn't lost a step yet ",
                    ImagePath = "https://www.hdwallpaper.nu/wp-content/uploads/2017/07/john_wick-15.jpg",
                    UnitPrice = 323.45,
                    CategoryID = 1,
                    Rating = 1.2M
                },

                new Product
                {
                    ProductID = 11,
                    ProductName = "Jumanji",
                    Description = "Jumanji Theatrical release poster Directed byJoe Johnston Produced by Scott Kroopf William Teitler Screenplay by Jonathan Hensleigh Greg Taylor Jim Strain Story by Greg Taylor Jim Strain Chris Van Allsburg Based onJumanji by Chris Van Allsburg Starring Robin Williams Kirsten Dunst David Alan Grier Bonnie Hunt Jonathan Hyde Bebe Neuwirth Music byJames Horner CinematographyThomas E. Ackerman Edited byRobert Dalva Production company TriStar Pictures Interscope Communications Teit",
                    UnitPrice = 465.67,
                    Rating = 2.55M,
                    CategoryID = 1,
                    ImagePath = "https://ocs-pl.oktawave.com/v1/AUTH_2887234e-384a-4873-8bc5-405211db13a2/splay/2020/08/jumanji-nastepny-poziom-hbo-go-premiera-1024x469.jpg"
                },
                 new Product
                 {
                   ProductID = 12,
                   ProductName = "The King Lion",
                   Rating = 2.58M,
                   Description = "The Lion King is a 1994 American animated musical drama film produced by Walt Disney Feature Animation and released by Walt Disney Pictures.It is the 32nd Disney animated feature film, and the fifth animated film produced during a period known as the Disney Renaissance. The Lion King was directed by Roger Allers and Rob Minkoff, produced by Don Hahn, and has a screenplay credited to Irene ",
                   CategoryID = 2,
                   ImagePath = "https://th.bing.com/th/id/OIP.HlIGl4gZgMb60_5bKeeY7wHaEv?pid=Api&rs=1",
                   UnitPrice  = 865.57,
                 },
                  new Product
                  {
                      ProductName = "UnCaged",
                      ProductID = 13,
                      CategoryID = 1,
                      Description = "47 Meters Down: Uncaged is a 2019 American-British survival horror film directed by Johannes Roberts and written by Roberts and Ernest Riera, and a stand alone sequel to 47 Meters Down None of the cast from the previous film returns here. The new cast consists of Sophie Nélisse, Corinne Foxx, Brianne Tju, Sistine Stallone, Davi Santos, Khylin Rhambo, Brec Bassinger, Nia Long, and John Corbett. The plot follows a group of girls who scuba dive to a sunken Mayan city, only to be trapped by a group",
                      UnitPrice = 130.54,
                      Rating = 8.66M,
                      ImagePath = "https://image.tmdb.org/t/p/original/2RuUdLbFI4YHeWQRuGaraRWmJxU.jpg"
                  }
                  ,

                  new Product
                  {
                      ProductID = 14,
                      CategoryID = 1,
                      ProductName = "The Man Who Killed Hitler and Then the Bigfoot",
                      ImagePath = "https://th.bing.com/th/id/OIP.xblYWK9ZK_8zfsQ9GMpoMAHaD4?pid=Api&rs=1",
                      UnitPrice = 567.89,
                      Description  = "Abigail was the wife of Nabal; she became a wife of the future King David after Nabal's death. Abigail was David's third wife, after Saul's daughter, Michal, whom Saul later married to Palti, son of Laish when David went into hiding, and Ahinoam. She became the mother of one of David's sons, who is listed in the Book of Chronicles under the name Daniel, in the Masoretic Text of the Books of Samuel as Chileab, and in the Septuagint text of 2 Samuel 3:3 as Δαλουια, Dalouia. Her name is..",
                      Rating = 5.88M
                  },

                  new Product
                  {
                      ProductID = 15,
                      CategoryID = 1,
                      ProductName = "Star Wars",
                      Description = "The Rise of Skywalker (also known as Star Wars: Episode IX – The Rise of Skywalker) is a 2019 American epic space opera film produced, co-written, and directed by J. J. Abrams.It is the third installment of the Star Wars sequel trilogy, following The Force Awakens (2015) and The Last Jedi (2017), and the final episode of the nine-part 'Skywalker saga'",
                      ImagePath = "https://static1.srcdn.com/wordpress/wp-content/uploads/2019/12/Star-Wars-The-Rise-of-Skywalker-international-poster.jpg",
                      Rating = 4.66M,
                      UnitPrice = 454.67
                  },

                  new Product
                  {
                    ProductID = 16,
                    CategoryID = 1,
                    ProductName = "Fast Furious 6",
                    Description = "Fast & Furious 6 (stylized onscreen as Furious 6) is a 2013 American action film directed by Justin Lin and written by Chris Morgan.A sequel to 2011's Fast Five, it is the sixth installment in the Fast & Furious franchise and stars Vin Diesel, Paul Walker, Dwayne Johnson, Michelle Rodriguez, Jordana Brewster, Tyrese Gibson, Chris Ludacris Bridges, Sung Kang, Luke Evans, Gina Carano, and John",
                    ImagePath = "http://jimoncars.files.wordpress.com/2013/05/fast-and-furious-6.jpg",
                    UnitPrice = 450.78,
                    Rating = 8.99M
                  },

                  new Product
                  {
                      ProductID = 17,
                      CategoryID = 1,
                      ImagePath = "http://moviestorrents.net/wp-content/uploads/2013/04/The-A-Team-2010.jpg",
                      ProductName = "The A Team",
                      Description = "The A-Team is an American action-adventure television series that ran on NBC from 1983 to 1987 about former members of a fictitious United States Army Special Forces unit. The members, after being court-martialed 'for a crime they didn't commit', escaped from military prison and, while still on the run, worked as soldiers of fortune.The series was created by Stephen J. Cannell and Frank Lupo.",
                      UnitPrice = 235.67,
                      Rating = 6.77M
                  },
                   new Product
                   {
                       ProductID = 18,
                       CategoryID = 1,
                      ProductName = "Triple Frontier",
                      Description = "Triple Frontier is a 2019 American action-adventure film directed by J. C. Chandor. Chandor and Mark Boal wrote the screenplay based on a Boal story. The film stars Ben Affleck, Oscar Isaac, Charlie Hunnam, Garrett Hedlund, and Pedro Pascal as a group of former U.S. Army Delta Force soldiers who reunite to plan a heist of a South American crime lord. The film was released by Netflix in theaters on March 6, 2019, before a worldwide streaming release on March 13, 2019; it received generally favora",
                      UnitPrice = 789.99,
                      ImagePath = "https://www.whats-on-netflix.com/wp-content/uploads/2019/03/triple-frontier-soundtrack.jpg",
                      Rating = 5.78M
                   },
                    new Product
                    {
                        ProductID = 19,
                        CategoryID = 1,
                        Rating = 5.66M,
                        UnitPrice = 789.99,
                        ProductName =  "Dead Pool",
                        Description = "Deadpool 2 is a 2018 American superhero film based upon the Marvel Comics character Deadpool.It is the eleventh installment in the X-Men film series, and is the sequel to 2016's Deadpool.The film was directed by David Leitch from a screenplay by Rhett Reese, Paul Wernick, and Ryan Reynolds, who stars in the title role alongside Josh Brolin, Morena Baccarin, Julian Dennison, Zazie Beetz, T.J ",
                        ImagePath = "https://weliveentertainment.com/wp-content/uploads/2016/02/deadpool_poster2a.jpg",
                    },
                    new Product
                    {
                        ProductID = 20,
                        CategoryID = 1,
                        UnitPrice = 400.00,
                        ProductName = "The Lego Movie",
                        Description = "The Lego Movie is a 2014 computer-animated adventure comedy film written and directed by Phil Lord and Christopher Miller from a story by Lord, Miller, and Dan and Kevin Hageman. Based on the Lego line of construction toys, its story focuses on an ordinary Lego minifigure who finds himself helping a resistance stop a tyrannical businessman from gluing everything in the Lego world",
                        ImagePath = "http://cdn.collider.com/wp-content/uploads/2017/02/the-lego-batman-movie-robin.jpg",
                        Rating = 7.3M
                    },

                    new Product
                    {
                        ProductID = 21,
                        CategoryID = 1,
                        ProductName  = "Murder On the  Orient Express",
                        Description = "Murder on the Orient Express Dust-jacket illustration of the first UK edition AuthorAgatha Christie Cover artistUnknown CountryUnited Kingdom LanguageEnglish GenreCrime novel PublisherCollins Crime Club Publication date 1 January 1934 Media typePrint Pages256 Preceded byThe Hound of Death Followed byUnfinished Portrait Murder on the Orient Express is a detective novel by English writer Agatha Christie featuring the Belgian detective Hercule Poirot. It was first published in the United Kingdom",
                        UnitPrice = 345.66,
                        ImagePath = "https://image.tmdb.org/t/p/original/rDAD6C0J48liXaVK11jamdKAatE.jpg",
                        Rating = 5.66M

                    },
                     new Product
                     {
                         ProductID = 22,
                         CategoryID = 1,
                         ProductName = "White Boy Rick",
                         Description = "White Boy Rick Theatrical release poster Directed byYann Demange Produced by John Lesher Julie Yorn Darren Aronofsky Scott Franklin Screenplay by Andy Weiss Logan Miller Noah Miller Based onRichard Wershe Jr. Starring Matthew McConaughey Richie Merritt Bel Powley Jennifer Jason Leigh Brian Tyree Henry Rory Cochrane RJ Cyler Jonathan Majors Eddie Marsan Taylour Paige Bruce Dern Piper Laurie Music byMax Richter CinematographyTat Radcliffe Edited byChris Wyatt Production companies Columbia",
                         ImagePath = "https://th.bing.com/th/id/OIP.aHpzNUueHujH1-hLoUsmhwHaFj?pid=Api&rs=1",
                         UnitPrice = 340.89,
                         Rating = 7.55M
                     },
                      new Product
                      {
                          ProductID = 23,
                          CategoryID = 1,
                          ProductName = "White Storm",
                          Description = "The White Storm 2 - Drug Lords is a 2019 Hong Kong action film directed by Herman Yau, produced by and starring Andy Lau. The film is a thematic sequel in-title-only to the 2013 film, The White Storm, starring returning cast member Louis Koo in a different role, and featuring a new storyline. The film was first announced on 15 March 2018. Production for The White Storm 2 - Drug Lords began on 23 June 2018 and wrapped up on 12 September 2018. The film was theatrically released on 5 July 2019 in C",
                          ImagePath = "https://th.bing.com/th/id/OIP.e-q7x8vkB333AiuvSaa9KQHaHa?pid=Api&rs=1",
                          UnitPrice = 650.89,
                          Rating = 3.5M
                      },

                      new Product
                      {
                        ProductID = 24,
                        CategoryID = 1,
                        ProductName = "The Equalizer 2",
                        Description = "The Equalizer 2 is a 2018 American action thriller film directed by Antoine Fuqua. It is the sequel to the 2014 film The Equalizer, which was based on the TV series of the same name. The film stars Denzel Washington, Pedro Pascal, Ashton Sanders, Melissa Leo, Bill Pullman, and Orson Bean in his final film role. It follows retired United States Marine and ex-DIA agent Robert McCall as he sets out on a path of revenge after one of his friends is murdered. The film is the fourth",
                        ImagePath = "https://image.tmdb.org/t/p/original/t8m4Z8Wo9MdhuvpoRCTVZgV3KDF.jpg",
                        UnitPrice = 689.00,
                        Rating = 5.76M
                     },
                     new Product
                     {
                        ProductID = 25,
                        CategoryID = 1,
                        ProductName = "Badges of Fury",
                        Description = "Badges of Fury Film poster Traditional不二神探 Simplified不二神探 MandarinBú Èr Shén Tàn CantoneseBat1 Ji6 San6 Taam3 Directed byWong Tsz-ming Produced byChui Po Chu Screenplay byCarbon Cheung StarringJet Li Wen Zhang Cecilia Liu Michelle Chen Ada Liu Music byRaymond Wong CinematographyKenny Tse Edited byAngie Lam Production company Beijing Enlight Pictures Hong Kong Pictures International My Way Film Company Intrend Entertainemt & Production HK Screen Art Distribu",
                        ImagePath = "https://ia.media-imdb.com/images/M/MV5BMjcyODQ3ODk1MF5BMl5BanBnXkFtZTgwNDI2NjI2MDE@._V1_UY1200_CR114,0,630,1200_AL_.jpg",
                        UnitPrice = 584.00,
                        Rating = 5.76M
                     },
                      new Product
                      {
                          ProductID = 26,
                          CategoryID = 1,
                          ProductName = "Bright",
                          ImagePath = "https://pbs.twimg.com/profile_images/929160557470531584/gW5ECUwR.jpg",
                          Description = "Bright Official release poster Directed byDavid Ayer Produced by Eric Newman David Ayer Bryan Unkeless Ted Sarandos Written byMax Landis Starring Will Smith Joel Edgerton Noomi Rapace Lucy Fry Édgar Ramírez Ike Barinholtz Music byDavid Sardy CinematographyRoman Vasyanov Edited by Michael Tronick Production company Overbrook Entertainment Trigger Warning Entertainment Grand Electric Netflix Distributed byNetflix Release date December 13, 2017 December 22, 2017",
                          UnitPrice = 567.77,
                         Rating = 4.55M
                      },

                     new Product
                     {
                         ProductID = 27,
                         CategoryID = 1,
                         ProductName = "The Dark Knight",
                        Description = "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan.Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman",
                        ImagePath = "http://getwallpapers.com/wallpaper/full/7/8/2/542338.jpg",
                        UnitPrice = 589.00,
                        Rating = 5.76M
                     },

                     new Product
                     {
                         ProductID = 28,
                         CategoryID = 1,
                         ProductName = "Den of Thieves",
                        Description = "Den of Thieves is a 2018 American action-crime film written, directed, and produced by Christian Gudegast. It stars Gerard Butler, Curtis '50 Cent' Jackson, Pablo Schreiber, O'Shea Jackson Jr., Evan Jones, Dawn Olivieri, Mo McRae, and Max Holloway. In the film, an elite group of County Sheriff Deputies look to stop a gang of thieves planning to rob the Federal Reserve in Los Angeles. Den of Thieves was distributed by STXfilms and released in the United States on January 19, 2018. The film receive",
                        ImagePath = "https://i.jeded.com/i/den-of-thieves-2018.106810.jpg",
                        UnitPrice = 529.00,
                        Rating = 5.66M
                     },

                      new Product
                     {
                         ProductID = 29,
                         CategoryID = 1,
                         ProductName = "Drive",
                        Description = "Drive Netflix release poster Directed byTarun Mansukhani Produced byHiroo Yash Johar Karan Johar Apoorva Mehta Written byTarun Mansukhani StarringSushant Singh Rajput Jacqueline Fernandez Vikramjeet Virk Sapna Pabbi Music bySongs: Tanishk Bagchi Amartya Bobo Rahut Javed-Mohsin Score: QARAN CinematographyVishal Sinha Edited byTarun Mansukhani Production company Dharma Productions Distributed byNetflix Release date 1 November 2019 Running time 119 minutes CountryInd…",
                        ImagePath = "http://filmint.nu/wp-content/uploads/2011/10/drive-1.jpg",
                        UnitPrice = 589.00,
                        Rating = 5.76M
                     },

                     new Product
                     {
                         ProductID = 30,
                         CategoryID = 1,
                         ProductName = "Special ID",
                        Description = "2013 film by Clarence Fok Special ID China poster Traditional特殊身份 Simplified特殊身份 MandarinTè Shū Shēn Fèn CantoneseDak6 Syu4 San1 Fan2 Directed byClarence Fok Produced byDonnie Yen Peter Pau Lu Zheng Written byClarence Fok StarringDonnie Yen Jing Tian Andy On Zhang Hanyu Ronald Cheng Collin Chou Music byDou Peng CinematographyPeter Pau Edited byCheung Ka-fai Production company Starlit Film China Film China Movie Channel Xi'an Suobao Film & TV Culture Communication Xi'an",
                        ImagePath = "http://www.dvd-covers.org/d/341084-2/Special_ID_2013_Scanned_Cover.jpg",
                        UnitPrice = 789.00,
                        Rating = 5.76M
                     },

                     new Product
                     {
                         ProductID = 31,
                         CategoryID = 1,
                         ProductName = "Anastasia",
                         Description = "Grand Duchess Anastasia Nikolaevna of Russia was the youngest daughter of Tsar Nicholas II, the last sovereign of Imperial Russia, and his wife, Tsarina Alexandra Feodorovna. Anastasia was the younger sister of Grand Duchesses Olga, Tatiana, and Maria, and was the elder sister of Alexei Nikolaevich, Tsarevich of Russia. She was murdered with her family by a group of Bolsheviks in Yekaterinburg on July 17, 1918. Persistent rumors of her possible escape circulated after her death, fueled by the fa",
                         ImagePath = "https://th.bing.com/th/id/OIP.mFbKBNjwNxopbPhiO6NMdQHaLH?pid=Api&rs=1",
                         UnitPrice = 456.77,
                         Rating = 7.88M
                     },

                     new Product
                     {
                         ProductID = 32,
                         CategoryID = 1,
                         ProductName = " The Rise of Skywalker",
                         Description = "Star Wars: The Rise of Skywalker (also known as Star Wars: Episode IX – The Rise of Skywalker) is a 2019 American epic space opera film produced, co-written, and directed by J. J. Abrams.It is the third installment of the Star Wars sequel trilogy, following The Force Awakens (2015) and The Last Jedi (2017), and the final episode of the nine-part 'Skywalker saga'",
                         ImagePath = "https://th.bing.com/th/id/OIP.X3nVqN2tx4of1t_llXzRIQHaEr?pid=Api&rs=1",
                         UnitPrice = 456.77,
                         Rating = 7.88M
                     },

                     new Product
                     {
                         ProductID = 33,
                         CategoryID = 1,
                         ProductName = "Shazam!",
                         Description = "Shazam! is a 2019 American superhero film based on the DC Comics character.Produced by New Line Cinema and distributed by Warner Bros. Pictures, it is the seventh installment in the DC Extended Universe (DCEU). Directed by David F. Sandberg from a screenplay by Henry Gayden, and a story by Gayden and Darren Lemke, the film stars Asher Angel as Billy Batson",
                         ImagePath = "https://th.bing.com/th/id/OIP.bWa3sEFHPQt7AT7mZN12kQHaJ1?pid=Api&rs=1",
                         UnitPrice = 456.77,
                         Rating = 7.98M
                     },

                     new Product
                     {
                         ProductID = 34,
                         CategoryID = 1,
                         ProductName = "Jumanji The Next Level",
                         Description = "Jumanji The Next Level Theatrical release poster Directed byJake Kasdan Produced by Dwayne Johnson Dany Garcia Hiram Garcia Matt Tolmach William Teitler Jake Kasdan Written by Jake Kasdan Jeff Pinkner Scott Rosenberg Based onJumanji by Chris Van Allsburg Starring Dwayne Johnson Jack Black Kevin Hart Karen Gillan Nick Jonas Awkwafina Danny Glover Danny DeVito Music byHenry Jackman CinematographyGyula Pados Edited by Mark Helfrich Steve Edwards Tara Timpone Production companies",
                         ImagePath = "https://th.bing.com/th/id/OIP.ADw2irGXwAeNU6DLmP0FbgHaK-?pid=Api&rs=1",
                         UnitPrice = 456.77,
                         Rating = 7.88M
                     },

                     new Product
                     {
                         ProductID = 35,
                         CategoryID = 1,
                         ProductName = "Mistress of Evil",
                         Description = "Mistress of Evil is a 2019 American 3D fantasy film produced by Walt Disney Pictures, directed by Joachim Rønning, and written by Linda Woolverton, Micah Fitzerman-Blue, and Noah Harpster. It is a sequel to the 2014 film Maleficent, with Angelina Jolie returning to portray the title role. Elle Fanning, Sam Riley, Imelda Staunton, Juno Temple and Lesley Manville also return to their previous roles, with Harris Dickinson replacing Brenton Thwaites from the first film and Chiwetel",
                         ImagePath = "https://image.tmdb.org/t/p/original/skvI4rYFrKXS73BJxWGH54Omlvv.jpg",
                         UnitPrice = 236.77,
                         Rating = 7.88M
                     },
                      // crafts

                     new Product
                     {
                         ProductID = 36,
                         CategoryID = 2,
                         ProductName = "The Quantified Cactus: An Easy Plant Soil Moisture Sensor",
                        Description = "This project is a good learning project to get comfortable with soldering and programming an Arduino.",
                        ImagePath = "https://images.pexels.com/photos/1030946/pexels-photo-1030946.jpeg?auto=compress\u0026cs=tinysrgb\u0026dpr=1\u0026w=500",
                        UnitPrice = 347.89,
                        Rating = 2.3M
                     },
                  new Product{
                    ImagePath = "https://user-images.githubusercontent.com/41929050/61567053-13938600-aa33-11e9-9780-104fe4019659.png",
                    ProductName = "Bling your Laptop with an Internet-Connected Light Show",
                    Description =  "Create a web-connected light-strip API controllable from your website, using the Particle.io.",
                     Rating = 2.8M,
                     UnitPrice = 349.90,
                     ProductID = 37,
                     CategoryID = 2,
                   },
                  new Product
                  {
                   ProductID = 38,
                    CategoryID = 2,
                   ProductName = "Bubblesort Visualization",
                    UnitPrice = 787.90,
                    Rating = 7.0M,
                    Description ="Visualization of sailor scouts sorted by bubblesort algorithm by their planet\u0027s distance from the sun",
                   ImagePath = "https://user-images.githubusercontent.com/41929050/61567054-13938600-aa33-11e9-9163-eec98e239b7a.png",
              },
            new Product
            {
                ProductID = 39,
                CategoryID = 3,
                Rating  = 6.8M,
                ProductName = "Ranch-Roasted Chicken and vegetables",
                UnitPrice = 5000.68,
                Description = "Crispy Ranch-roasted chicken, tender veggies, and crunchy croutons make for one stellar sheet-pan supper. Swap out any seasonal veggies you like and dinner is served!",
                ImagePath = "https://www.simplyrecipes.com/wp-content/uploads/2020/08/Ranch-Sheet-Pan-Chicken-LEAD-5-600x840.jpg",
              }
             };
            return products;
        }
       
    }

}