using System;

namespace wallet{
    class Wallet{
        private double money;
        public void AddMoney(double amt){
            money += amt;
        }
        public double GetBalance(){
            return money;
        }
    }
}