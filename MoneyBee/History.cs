//---------------------------------------------------------------------
//
// MoneyBee: History
//
//
// Purpose: The class functions in managing the history of the done and 
//          undone commands by the user, managing the undo and redo
//          feature avaiable to the user
//---------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBee
{
    public class History
    {      
        protected Stack<Command> doneCommands = new Stack<Command>(); // doneComands:   those commands that are currently executed
        protected Stack<Command> undoneCommands = new Stack<Command>(); // undoneCommands: commands which were undone

        //---------------------------------------------------------------------
        // Executes the passed command and stores it on the doneCommands stack
        // and clears the old undone command permanently
        // params: (in)
        //---------------------------------------------------------------------
        public void doCommand(Command cmd)
        {
            cmd.execute();
            undoneCommands.Clear();
            doneCommands.Push(cmd);
        }

        //---------------------------------------------------------------------
        // Undoes the last executed command if there is at least one command
        // to undo. Condition is checked before the function is called
        // params: ()
        //---------------------------------------------------------------------
        public void undo()
        {
            Command toUndo = doneCommands.Pop();
            toUndo.unexecute();
            undoneCommands.Push(toUndo);
        }

        //---------------------------------------------------------------------
        // Redoes the last unndone command if there is at least one command
        // to redo. Condition is checked before the functions is called
        // params: ()
        //---------------------------------------------------------------------
        public void redo()
        {
            Command toDo = undoneCommands.Pop();
            toDo.execute();
            doneCommands.Push(toDo);
        }

        //---------------------------------------------------------------------
        // Checks to see if there are any done commands
        // params: ()
        //---------------------------------------------------------------------
        public bool doneIsEmpty()
        {
            return !(doneCommands.Any());
        }

        //---------------------------------------------------------------------
        // Checks to see if there are any undone commands
        // params: (in/out/inout, ...)
        //---------------------------------------------------------------------
        public bool unDoneIsEmpty()
        {
            return !(undoneCommands.Any());
        }

        //---------------------------------------------------------------------
        // Peeks the done commands to see what command is ontop. Used to
        // determine what to do when executing the redo of a command
        // depending on the type of the command
        // params: ()
        //---------------------------------------------------------------------
        public Command peekDone()
        {
            return doneCommands.Peek();
        }

        //---------------------------------------------------------------------
        // Peeks the undone commands to see what command is ontop. Used to
        // determine what to do when executing the multiple undo of a command
        // depending on the type of the command
        // params: ()
        //--------------------------------------------------------------------
        public Command peekUndone()
        {
            return undoneCommands.Peek();
        }

        public void clear()
        {
            doneCommands.Clear();
            undoneCommands.Clear();
        }
    }
}
