using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDManage
{
    class User
    {
        /** User Level Break Down
         * Level 1 = Guess
         * Level 2 = Genral User
         * Level 3 = Admin
         **/
        int userLevel;

        public void setUserLevel(int level){
            userLevel = level;
        }

        public int getUserLevel() {
            return userLevel;
        }

        public User(int userLevel) {
            this.userLevel = userLevel;
        }

        public User(){
            userLevel = 1;
        }
    }
}
