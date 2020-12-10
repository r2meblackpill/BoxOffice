﻿using System;
using System.IO;
using System.Collections.Generic;

namespace BoxOffice
{
    class Program
    {
        class Movie
        {
            int id;
            string title;
            long lifetimeGross;

            public Movie(int _id, string _title, long _lifetimeGross)
            {
                id = _id;
                title = _title;
                lifetimeGross = _lifetimeGross;
            }

            public int Id
            {
                get { return id; }
            }
            public string Title
            {
                get { return title; }
            }
            public long LifeTimeGross
            {
                get { return lifetimeGross; }
            }

            class MovieList
            {
                List<Movie> movies;
                long totallifetimeGross;
            
            public MovieList()
            {
                movies = new List<Movie>();
                totallifetimeGross = 0;
            }

            public void AddMoviesToList(int id, string title, long gross)
            {
                Movie newMovie = new Movie(id, title, gross);
                movies.Add(newMovie);
            }

            public void PrintAllMovies()
                {
                    foreach(Movie movie in movies)
                    {
                        Console.WriteLine($"{movie.Id}, {movie.Title} has earned {movie.lifetimeGross}");
                    }
                }
        }
        static void Main(string[] args)
            {
                string filePath = @"C:\Users\opilane\samples";
                string fileName = @"boxOffice.txt";
                string fullFilePath = Path.Combine(filePath, fileName);

                string[] linesFromFile = File.ReadAllLines(fullFilePath);

                foreach(string line in linesFromFile)
                {
                    string[] tempArray = line.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                    int movieId = int.Parse(tempArray[0]);
                    string moveTitle = tempArray[1];
                    string totalGrossTemp = tempArray[2].Substring(1);
                    Console.WriteLine(totalGrossTemp);
                    long MovieGross = long.Parse(totalGrossTemp);
                    myMovies.AddMoviesToList(movieId, moveTitle, MovieGross);
                }
            }
        }
    }
}
