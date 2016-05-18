﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FrameWorkPokemonGBA;
using Gabriel.Cat.Extension;
namespace Pokedex
{
    /// <summary>
    /// Interaction logic for PokemonPokedex.xaml
    /// </summary>
    public partial class PokemonPokedex : UserControl
    {
        FrameWorkPokemonGBA.Pokemon pokemon;
        public event EventHandler Selected;
        public PokemonPokedex(FrameWorkPokemonGBA.Pokemon pokemon)
        {
           
            
            InitializeComponent();
            this.Pokemon = pokemon;
            imgPokemon.MouseDown += (s, e) =>
            {
                if (Selected != null)
                    Selected(this, new EventArgs());
            };
        }

        public Pokemon Pokemon
        {
            get
            {
                return pokemon;
            }

            set
            {
                if (value == null)
                    throw new NullReferenceException();
                pokemon = value;
                imgPokemon.SetImage(pokemon.ImgFrontal.ToBitmap());
            }
        }
    }
}