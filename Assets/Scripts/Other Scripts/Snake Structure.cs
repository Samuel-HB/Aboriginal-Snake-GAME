using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exo1
{
    class Program
    {
        //class Position
        class Vector2Int
        {
            public int x;
            public int y;

            public Vector2Int(int width, int height)
            {
                x = width;
                y = height;
            }
        }

        class Fruit
        {
            Vector2Int position;
            int score; // on récupère la valeur du fruit quand on le mange

            public Fruit()
            {
                Random rng = new Random();
                score = rng.Next();
            }
        }

        enum Direction
        {
            up,
            down,
            right,
            left,
        }

        class Snake
        {
            int size;
            int speed;
            Direction direction;
            Vector2Int position;

            public Snake(int x, int y)
            {
                position = new Vector2Int(x, y);
            }

            void Grow()
            {
                //size += fruitSize;            // en commentaire car provoque une erreur
            }

            public void Eat(Fruit fruit)
            {
                //Grow(fruit.score);            // provoque une erreur
            }

            public void Move(Direction direction)
            {

            }
        }

        class Score
        {
            int score;
            int winScore;
        }

        class Level
        {
            public Vector2Int dimension;
            public Snake snake;
            public List<Fruit> fruits;

            public Level(int width, int height)
            {
                dimension = new Vector2Int(width, height);
            }

            public void SpawnFruit(Fruit fruit)
            {

            }

            void Display()
            {
                //on affiche le serpent, le =s fruits, mais aussi la grille
            }
        }

        static void Main(string[] args)
        {
            // if(Direction.up == Direction.down) // pour comparer des directions entre elles

            Level level = new Level(10, 10);
            Snake snake = new Snake(0, 0);
            level.snake = snake;

            for (int i = 0; i < 5; i++)
            {
                Fruit fruit = new Fruit();
                level.fruits.Add(fruit);
                level.SpawnFruit(fruit);
            }

            while (true)//le jeu tourne
            {
                //if (player.Press)...
            }
            //Score.Add(level.fruits[0].score);             // provoque une erreur 

        }
    }
}
