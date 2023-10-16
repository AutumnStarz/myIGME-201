using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    internal class Program
    {
        public class Pets
        {
            public List<Pet> petList = new List<Pet>();

            public Pet this[int nPetEl]
            {
                get
                {
                    Pet returnVal;
                    try
                    {
                        returnVal = (Pet)petList[nPetEl];
                    }
                    catch
                    {
                        returnVal = null;
                    }

                    return (returnVal);
                }

                set
                {
                    // if the index is less than the number of list elements
                    if (nPetEl < petList.Count)
                    {
                        // update the existing value at that index
                        petList[nPetEl] = value;
                    }
                    else
                    {
                        // add the value to the list
                        petList.Add(value);
                    }
                }
            }

            public int Count
            {
                get
                {
                    return petList.Count;
                }
            }

            public Pet Add(Pet pet)
            {
                petList.Add(pet);
            }

            public Pet Remove(Pet pet)
            {
                petList.Remove(pet);
            }

            public int RemoveAt(int petEl)
            {
                petList.RemoveAt(petEl);
            }

        }
        public abstract class Pet : Pets
        {
            private string name;
            public int age;

            public string Name
            {
                get 
                { 
                    return name;
                }
                set 
                {
                    name = value; 
                }

            }

            public abstract string Eat();
            public abstract string Play();
            public abstract string GotoVet();

            public Pet(string name, int age)
            {
                this.name = name;
                this.age = age;
                
            }
        }
        public interface ICat
        {
            void Eat();
            void Play();
            void Scratch();
            void Purr();


        }

        public interface IDog
        {
            void Eat();
            void Play();
            void Bark();
            void NeedWalk();
            void GotoVet();
        }

        public class Cat : Pet, ICat
        {
            public override string Eat()
            {
                return Eat();
            }

            public override string Play()
            {
                return Play();
            }

            public override string GotoVet()
            {
                return GotoVet();
            }

            public void Purr()
            {

            }

            public void Scratch()
            {

            }
        }

        public class Dog : Pet, IDog
        {

        }
        static void Main(string[] args)
        {
        }
    }
}
