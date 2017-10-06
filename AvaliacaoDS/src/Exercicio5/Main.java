/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Exercicio5;

import javax.swing.JOptionPane;

/**
 *
 * @author Bruno
 */
public class Main {
    
    public static void main(String[] args) {
        
        Definicoes calculo = new Definicoes();
        
        double capital = 10.000;
        double tjuro = 3/100;
        double prazo = 3;
        
        calculo.ObetenhaMontante(capital, tjuro, prazo);
    }
    
}
