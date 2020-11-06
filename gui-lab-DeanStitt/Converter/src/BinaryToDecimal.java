import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;

class Conversion extends JFrame implements ActionListener {// Create labels and buttons defaults
	private JTextField txtFld = new JTextField(10);
	private JLabel NumEntered = new JLabel("Enter Binary to be converted");
	private JButton convert = new JButton("Calculate");
	private JButton zero = new JButton("0");
	private JButton one = new JButton("1");
	private JLabel binaryToDec = new JLabel("");

	public Conversion() {
		setLayout(new FlowLayout()); // Set layout and close option
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setSize(400, 250);
		setVisible(true);

		convert.addActionListener(this);// create button listeners
		zero.addActionListener(this);
		one.addActionListener(this);
		add(txtFld);
		add(zero);
		add(one);
		add(convert);
		add(binaryToDec);
	}

	public void actionPerformed(ActionEvent e) {
		if (e.getSource() == zero) {
			txtFld.setText(txtFld.getText() + "0");// set entered values
		} else if (e.getSource() == one) {
			txtFld.setText(txtFld.getText() + "1");
		} else if (e.getSource() == convert) {// convert binary to dec
			String input = txtFld.getText();
			char[] inputNum = input.toCharArray();
			int convertNum = 0;
			int power = 1;
			for (int i = (inputNum.length - 1); i >= 0; i--) {
				int nextInt = Character.getNumericValue(inputNum[i]);
				System.out.println(nextInt);
				convertNum += (nextInt * power);
				power = power * 2;
			}
			binaryToDec.setText(String.valueOf(convertNum));
		}

	}
}

public class BinaryToDecimal {
	public static void main(String[] args) {
		Conversion convert = new Conversion();
	}

}