﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Encapsulation
{
    internal struct Phonebook
    {
        #region Attributes

        private string[] Names;
        private int[] Numbers;
        #endregion

        #region Properties

        public int Size { get; } //Readonly Property
        #endregion

        #region Constructor

        public Phonebook(int size)
        {
            Size = size;
            Names = new string[Size];
            Numbers = new int[Size];
        }

        #endregion

        #region Methods

        // Add Person To Notebook

        public void AddPerson(int Position , string PersonName , int PhoneNumber)
        {
            if (Names is not null && Numbers is not null)
            {
                if (Position < Size)
                {
                    Names[Position] = PersonName;
                    Numbers[Position] = PhoneNumber;
                }
            }  
        }

        #endregion


        #region Getter - Setter

        public int GetPersonNumber(string PersonName)
        {
            if (Names is not null && Numbers is not null)
            {
                for (int i = 0; i < Numbers.Length; i++)
                {
                    if (Names[i] == PersonName)
                    {
                        return Numbers[i];
                    }
                }
            }
            return -1;
        }

        // Setter

        public void SetPersonNumber(String personName, int NewNumber)
        {
            if (Names is not null && Numbers is not null)
                for (int i = 0; i < Names.Length; i++)
                    if (Names[i] == personName)
                    {
                        Numbers[i] = NewNumber;
                        break;
                    }
        }
        #endregion

        #region Indexer

        // Special Property

        //1. Named With Keyword this 
        //2. Can Take Parameter

        // Note["Mohamed"]

        public int this[string name]
        {
            get {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < Numbers.Length; i++)
                    {
                        if (Names[i] == name)                       
                            return Numbers[i];                        
                    }
                }
                return -1;
            }

            set {
                if (Names is not null && Numbers is not null)
                    for (int i = 0; i < Names.Length; i++)
                        if (Names[i] == name)
                        {
                            Numbers[i] = value;
                            break;
                        }
            }
        }


        // 0 :: Waleed :: 123
        public string this[int index] // Readonly Indexer
        {
            get
            {

                return $"{index} :: {Names[index]} :: {Numbers[index]}";
            }
        }
        #endregion
    }
}
