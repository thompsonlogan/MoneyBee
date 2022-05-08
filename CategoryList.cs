//---------------------------------------------------------------------
// MoneyBee: CategoryList.cs (Class/Linked List)
//
//
// Purpose: Linked List of Category Objects with operations
//
// Input:   Only inputs needed are for adding categories (Category
//          object), getting the index of a category in the list
//          (string -title), and getting a category from a list
//          (int -index).
//
// Output:  The list is created at the time of form creation and
//          updated dynamically as categories are created by the user.
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBee
{

    //---------------------------------------------------------------------
    // Classlet contents for nodes of the CategoryList
    // params: none
    //---------------------------------------------------------------------
    public class CategoryNode
    {
        public CategoryNode next;
        public Category Data;
    }

    public class CategoryList
    {
        public CategoryNode head;

        //---------------------------------------------------------------------
        // Adds a new category to the linked list (sorted by time of creation)
        // params: (in)
        //---------------------------------------------------------------------
        public void AddCategory(Category inData)
        {
            CategoryNode newCategoryNode = new CategoryNode();
            newCategoryNode.Data = inData;

            CategoryNode currentNode;

            if (head == null)
            {
                newCategoryNode.next = head;
                head = newCategoryNode;
            }
            else
            {
                currentNode = head;

                while (currentNode.next != null)
                    currentNode = currentNode.next;

                newCategoryNode.next = currentNode.next;
                currentNode.next = newCategoryNode;
            }
        }

        //---------------------------------------------------------------------
        // Returns the index of the category with title passed as parameter
        // params: (in)
        //---------------------------------------------------------------------
        public int getIndex(string title)
        {
            CategoryNode currentNode;
      
            if (head == null)
                return -1;
            else
            {
                currentNode = head;
                int count = 0;

                while (currentNode != null)
                {
                    if (currentNode.Data.getCategoryTitle() == title)
                        return count;

                    currentNode = currentNode.next;
                    count++;
                }
                return -1;
            }            
        }

        //---------------------------------------------------------------------
        // Returns the length of the linked list
        // params: none
        //---------------------------------------------------------------------
        public int getLength()
        {
            int count = 0;
            CategoryNode currentNode = head;
            while (currentNode != null)
            {
                currentNode = currentNode.next;
                count++;
            }
            return count;
        }

        //---------------------------------------------------------------------
        // Returns the category object specified at index passed in parameter
        // params: (in)
        //---------------------------------------------------------------------
        public Category getCategory(int i)
        {
            if (i == -1)//no category is selected
                return null;
            else
            {
                CategoryNode currentNode = head;

                while (i > 0 && currentNode != null)
                {
                    currentNode = currentNode.next;
                    i--;
                }

                if (currentNode != null)
                    return currentNode.Data;
                else
                    return null;
            }
        }

        //---------------------------------------------------------------------
        // Returns true of false based on whether the category title already
        // exists for the current user
        // params: (in)
        //---------------------------------------------------------------------
        public bool categoryExists(string cateogryTitle)
        {
            CategoryNode currentNode = head;
            while (currentNode != null)
            {
                if(currentNode.Data.getCategoryTitle().Equals(cateogryTitle, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                currentNode = currentNode.next;
            }
            return false;
        }

        //---------------------------------------------------------------------
        // Clears the list of categories be setting the head of the list to null
        // params: ()
        //---------------------------------------------------------------------
        public void clear()
        {
            head = null;
        }
    }
}
