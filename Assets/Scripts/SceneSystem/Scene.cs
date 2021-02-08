using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PopKuru
{
    public abstract class Scene
    {

        public Scene NextScene;
        protected string SceneType;
        protected Menu Menu; // reference to the available menu
        protected GameState GameState;    

        // Declare whether the current scene is done.
        protected bool isDone = false;
        public bool IsDone { 
            get {return this.isDone;}
            protected set {this.isDone = value;}
        }

    
        
        
        
        
        
        
        
        // behaviors that all narrative scenes will have
            // Listen for user input and respond as needed
            // Query the game state for the next scene

            // Query the game state for the available menu class
            // Open / close menu 
            // Query the game 

            // Background Images and Transitions

            // Music and Transitions

            // Sound FX


        // Specific behaviors by type
        // StandardScene
            // Narrative Dialogue
            // Interactive Dialogue
            // Expressions and position commands
            // Character sprites
            // Character transitions
            // Cast of characters
            
        // CutScene
            // Narrative Dialogue

        // RouteMapScene
            // Clickable icons (is that part of its menu?)

    }
}
