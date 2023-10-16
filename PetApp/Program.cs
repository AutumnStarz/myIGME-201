using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    internal class Program
    {
        //create pets class
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

            //add
            public Pet Add(Pet pet)
            {
                petList.Add(pet);
                return petList[0];
            }
            //remove
            public Pet Remove(Pet pet)
            {
                petList.Remove(pet);
                return petList[0];
            }
            //remove at a specific spot
            public int RemoveAt(int petEl)
            {
                petList.RemoveAt(petEl);
                return petList.Count;
            }

        }
        //create pet class
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

            public Pet()
            {

            }

            public Pet(string name, int age)
            {
                this.name = name;
                this.age = age;
                
            }
        }
        public interface ICat
        {
         


        }

        public interface IDog
        {
       
        }
        
        //create cat class
        public class Cat : Pet, ICat
        {
            public override string Eat()
            {
                return "Eat";
            }

            public override string Play()
            {
                return "Play";
            }

            public override string GotoVet()
            {
                return "Going to vet";
            }

            public string Purr()
            {
                return "purrrrrr";
            }

            public string Scratch()
            {
                return "scratch";
            }
        }

        //create dog class
        public class Dog : Pet, IDog
        {
            public string license;

            public string Bark()
            {
                return "bark";
            }
            public string NeedWalk()
            {
                return "Walk";
            }
            public override string Eat()
            {
                return "eat";
            }

            public override string Play()
            {
                return "play";
            }

            public override string GotoVet()
            {
                return "going to vet";
            }
        }
        static void Main(string[] args)
        {
            //create pet variables
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets();
            Random rand = new Random();
            if (rand.Next(1, 11) == 1)
            {
                if (rand.Next(0, 2) == 0)
                {
                    // add a dog
                    thisPet.Add(dog);

                }
                else
                {
                    // else add a cat
                    thisPet.Add(cat);

                }
            }
            else
            {
                // choose a random pet from pets and choose a random activity for the pet to do
            }



        }
    }
}
