/**
 * Created with IntelliJ IDEA.
 * User: p1t3rr31
 * Date: 10/16/13
 * Time: 3:30 PM
 * To change this template use File | Settings | File Templates.
 */

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.*;
import java.util.Scanner;
import javax.swing.*;

public class modFy extends JFrame {
    modFy(){
        setUp();
    }
    private void setUp()
    {

        this.setTitle("Test");
        this.setDefaultCloseOperation(EXIT_ON_CLOSE);
        this.setSize(300,300);

        final JTextField modBox = new JTextField(10);

        JButton btnLoad=new JButton("Load");
        JButton btnSave=new JButton("Save");

        JPanel box =new JPanel();
        box.setSize(300,300);

        box.add(modBox);
        box.add(btnLoad);
        box.add(btnSave);

        this.setContentPane(box);

        btnLoad.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent actionEvent) {
                String test=read();
                String currentL=null;
                while (test !=null)
                {
                    currentL+=test+"/n";
                    test=read();
                }
            }
        });

    }
    private String read()
    {
        File red= new File("../filediTesto.txt");
        Scanner reader=null;
        try
        {
            reader = new Scanner(red);
        }
        catch (FileNotFoundException exc)
        {

        }

        return reader.nextLine();


    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(new Runnable()	{
            @Override
            public void run(){
                modFy ex = new modFy();
                ex.setVisible(true);
            }
        });
    }

}
