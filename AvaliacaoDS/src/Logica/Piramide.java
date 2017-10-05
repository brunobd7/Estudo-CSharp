/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Logica;

/**
 *
 * @author Bruno
 */
public class Piramide {
    
    
    public int getMenorValor(int []valor){
        int menor = 0;
        
        for(int i =0 ; i<valor.length; i++){
            
            if(i==0){
                menor = valor[0];
            }
            
            if(valor[i]< menor){
                menor = valor[i];
            }
            
            
        }
        System.out.println(""+menor); 
        return menor;
        
    }
    
    public int percorreP(int []v1,int []v2,int []v3,int []v4){
        int soma;
        int m=0; //menor
        int m2=0;
        int m3=0;
        int m4=0;
        
         for(int i =0 ; i<v1.length; i++){
            
            if(i==0){
                m = v1[0];
            }
            
            if(v1[i]< m){
                m = v1[i];
            }
        }
         
        for(int i =0; i<v2.length; i++){
              
             if(i==0){
                 m2 = v2[0];
             }
             
             if(v2[i]<m2){
                 m2 = v2[i];
             }
        }
        
        for(int i =0; i<v3.length;i++){
            
            if(i==0){
                m3 = v3[0];
            }
            
            if(v3[i]<m3){
                m3 = v3[i];
            }
        }
        for(int i =0; i<v4.length;i++){
            
            if(i==0){
                m4 = v4[0];
            }
            
            if(v4[i]<m4){
                m4 = v4[i];
            }
        }
        
              
        soma=m+m2+m3+m4;        
        System.out.println(m+"+"+m2+"+"+m3+"+"+m4+"="+soma);
        return soma;
          
    }
}
