﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6
{
    class BankAccount
    {
        private string ownerName;
        private string ownerAddress;
        private decimal balance;
        public BankAccount(string ownerName, string ownerAddress, decimal balance)
        {
            this.ownerName = ownerName;
            this.ownerAddress = ownerAddress;
            this.balance = balance;
        }
        public void ChangeOwnerAddress(string address)
        {
            this.ownerAddress = address;
        }
        public void UpdateBalance(decimal amount) { this.balance += amount; }
        public string OwnerName { get { return this.ownerName; } }
        public string OwnerAddress { get { return this.ownerAddress; } }
        public decimal Balance { get { return this.balance; } }


        public BankAccountMemento StoreState()
        {
            return new BankAccountMemento(this.ownerName, this.ownerAddress, this.balance);
        }
        public void RestoreState(BankAccountMemento memento)
        {
            this.ownerName = memento.OwnerName;
            this.ownerAddress = memento.OwnerAddress;
            this.balance = memento.Balance;
        }

    }
}
