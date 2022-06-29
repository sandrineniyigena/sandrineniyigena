from setuptools import find_namespace_packages

using System.Diagnostics.Contracts;
using Microsoft.VisualBasic.CompilerServices
public class Employee
    {
        // properties
        public string EmpName { get; set; }
        public Contract EmpContract { get; set; }
        public Department EmpDepart{get;set}
        public double hidedate{get;set}
        public enum contract
        {
            permanent;
            casual;
        }
        public enum Department{
            Finance;
            IT;
            Production;
            Sales;
            Security;
        }
        public double calculatesalary_casual(double hours, double payrate){
            var netpay_amount= hours*payrate;
            return netpay_amount;
        }
        public double calculatesalary_permanent(double gross_salary){
            var deduction=(gross_salary*0.3)+(gross_salary*0.03)+(gross_salary*0.003);
            return gross_salary-deduction;
            var nbrofyears;
            var bonus_amount;
            console.writeline("enter number of years");
            console.readline(nbrofyears)
        }
        if(contract=permanent){//this condition will check if contract is permanent and return his or her salary
            if ( nbrofyears>=3){  
                 if(department=IT){
                bonus_amount=gross_salary*0.025*0.3;

                return gross_salary-deduction+bonus_amount;
                 }
                 
                 else(department=sales){
                 bonus_amount=gross_salary*0.015*0.3;
                return gross_salary-deduction+bonus_amount;
                 }
                 else{
                    bonus_amount=gross_salary*0.3;
                return gross_salary-deduction+bonus_amount; 
                 }
            }
            else( nbrofyears>=5){
                if(department=IT){
                var bonus_amount=gross_salary*0.025*0.2;

                return gross_salary-deduction+bonus_amount;
                 }
                 else(department=sales){
                 bonus_amount=gross_salary*0.015*0.2;
                return gross_salary-deduction+bonus_amount;
                 }
                 else{
                    bonus_amount=gross_salary*0.2;
                return gross_salary-deduction+bonus_amount; 
                 }
            else{
                 if(department=IT){
                bonus_amount=gross_salary*0.025;

                return gross_salary-deduction+bonus_amount;
                 }
                 else(department=sales){
                 bonus_amount=gross_salary*0.015;
                return gross_salary-deduction+bonus_amount;
                 }
                 else{
                    bonus_amount=gross_salary;
                return gross_salary-deduction+bonus_amount; 
                 }
            }

            }
        }
        else(contract=casual){ //this condition will check if contract is casual and return his or her salary
            if(hours>=40){
                if(department=IT){
                var overtime;    
                bonus_amount=netpay_amount*0.025;
                return netpay_amount;
                return overtime=payrate*hours*1.3;
                }
                else(department=sales){
                 bonus_amount=netpay_amount*0.015;
                return netpay_amount;
                return overtime=payrate*hours*1.3;
                 }
                 else{
                    bonus_amount=gross_salary*0.3;
                return gross_salary-deduction+bonus_amount; 
                return overtime=payrate*hours*1.3;
                 }

            }
            else(hours<=40){

                if(department=IT){
                    
                bonus_amount=netpay_amount*0.025;
                return netpay_amount;
                
                }
                else(department=sales){
                 bonus_amount=netpay_amount*0.015;
                return netpay_amount;
                
                 }
                 else{
                    bonus_amount=gross_salary*0.3;
                return gross_salary-deduction+bonus_amount; 
                
                 }
            }
        }
    }          
        