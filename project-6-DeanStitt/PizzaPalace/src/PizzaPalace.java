import java.awt.BorderLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.text.DecimalFormat;

import javax.swing.BorderFactory;
import javax.swing.ButtonGroup;
import javax.swing.JButton;
import javax.swing.JCheckBox;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JRadioButton;
import javax.swing.JTextField;

public class PizzaPalace extends JFrame {
	private JPanel basePanel;
	private JPanel toppingPanel;
	private JPanel drinkPanel;
	private JPanel buttonPanel;
	
	private JTextField quantity;

	private JButton calcButton;
	private JButton exitButton;

	private JRadioButton thinCrust;
	private JRadioButton raisedCrust;
	private ButtonGroup pizzaButtonGp;

	private JCheckBox cheese;
	private JCheckBox tuna;
	private JCheckBox pepperoni;
	private JCheckBox mushrooms;

	private JRadioButton coke;
	private JRadioButton dietCoke;
	private JRadioButton sweetTea;
	private ButtonGroup drinkButtonGp;

	public PizzaPalace() {
		setTitle("Order Calculator");// create panels

		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		setLayout(new BorderLayout());

		BasePanel base = new BasePanel();
		base.Base();
		ToppingPanel top = new ToppingPanel();
		top.Topping();
		DrinkPanel drink = new DrinkPanel();
		drink.Drink();

		buildButtonPanel();

		add(basePanel, BorderLayout.WEST);
		add(toppingPanel, BorderLayout.CENTER);
		add(drinkPanel, BorderLayout.EAST);
		add(buttonPanel, BorderLayout.SOUTH);

		setSize(450, 450);
		setVisible(true);
	}

	private void buildButtonPanel() {// create button panel

		buttonPanel = new JPanel();

		calcButton = new JButton("Calculate");
		exitButton = new JButton("Exit");

		calcButton.addActionListener(new CalcButtonListener());
		exitButton.addActionListener(new ExitButtonListener());

		buttonPanel.add(calcButton);
		buttonPanel.add(exitButton);
	}

	private class BasePanel{

		JPanel Base() {// create base panel

		basePanel = new JPanel();

		basePanel.setLayout(new GridLayout(2, 1));

		thinCrust = new JRadioButton("Thin Crust", true);
		raisedCrust = new JRadioButton("Raised Crust");

		pizzaButtonGp = new ButtonGroup();
		pizzaButtonGp.add(thinCrust);
		pizzaButtonGp.add(raisedCrust);

		basePanel.setBorder(BorderFactory.createTitledBorder("Base"));

		basePanel.add(thinCrust);
		basePanel.add(raisedCrust);
		return basePanel;
	}
	}

	private class DrinkPanel {

		JPanel Drink() {// create drink panel

		drinkPanel = new JPanel();

		drinkPanel.setLayout(new GridLayout(4, 1));

		coke = new JRadioButton("Coke");
		dietCoke = new JRadioButton("Diet Coke", true);
		sweetTea = new JRadioButton("Sweet Tea");
		quantity = new JTextField("0");

		drinkButtonGp = new ButtonGroup();
		drinkButtonGp.add(coke);
		drinkButtonGp.add(dietCoke);
		drinkButtonGp.add(sweetTea);
		

		drinkPanel.setBorder(BorderFactory.createTitledBorder("Drinks"));

		drinkPanel.add(coke);
		drinkPanel.add(dietCoke);
		drinkPanel.add(sweetTea);
		drinkPanel.add(quantity);
		return drinkPanel;
	}
	}

	private class ToppingPanel {

		JPanel Topping() {// create topping panel
			toppingPanel = new JPanel();

			toppingPanel.setLayout(new GridLayout(4, 1));

			cheese = new JCheckBox("Cheese");
			tuna = new JCheckBox("Tuna");
			pepperoni = new JCheckBox("Pepperoni");
			mushrooms = new JCheckBox("Mushrooms");

			toppingPanel.setBorder(BorderFactory.createTitledBorder("Topping"));

			toppingPanel.add(cheese);
			toppingPanel.add(tuna);
			toppingPanel.add(pepperoni);
			toppingPanel.add(mushrooms);
			return toppingPanel;
		}
	}

	private class CalcButtonListener implements ActionListener {// create button listener
		public void actionPerformed(ActionEvent e) {
			double subtotal, tax, total;

			CalculateOrder order = new CalculateOrder();

			subtotal = order.getBaseCost() + order.getToppingCost() + order.getDrinksCost();

			tax = subtotal * .10;

			total = subtotal + tax;

			DecimalFormat dollar = new DecimalFormat("0.00");

			JOptionPane.showMessageDialog(null, "Subtotal: $" + dollar.format(subtotal) + "\n" + "Tax: $"
					+ dollar.format(tax) + "\n" + "Total: $" + dollar.format(total));
		}
	}

	private class CalculateOrder {

		private double getBaseCost() {// calculate base cost

			double thinCr = 10.00;
			double raisedCr = 15.00;

			double pizzaCost = 0.0;

			if (thinCrust.isSelected())
				pizzaCost = thinCr;
			else
				pizzaCost = raisedCr;

			return pizzaCost;
		}

		private double getDrinksCost() {// calculate drink cost

			double COKE = 1.00;
			double DIETCOKE = 1.25;
			double SWEETTEA = 2.00;
			int count = Integer.parseInt(quantity.getText());
			if(count < 0)
			{
				
			}
			double drinkCost = 0.0;

			if (coke.isSelected())
				drinkCost = COKE + count;
			else if (dietCoke.isSelected())
				drinkCost = DIETCOKE + count;
			else if (sweetTea.isSelected())
				drinkCost = SWEETTEA + count;

			return drinkCost;
		}

		private double getToppingCost() {// calculate topping cost
			double CHEESE = 4.50;
			double TUNA = 2.50;
			double PEPPERONI = 3.00;
			double MUSHROOMS = 1.50;

			double toppingCost = 0.0;

			if (cheese.isSelected())
				toppingCost += CHEESE;
			if (tuna.isSelected())
				toppingCost += TUNA;
			if (pepperoni.isSelected())
				toppingCost += PEPPERONI;
			if (mushrooms.isSelected())
				toppingCost += MUSHROOMS;

			return toppingCost;
		}
	}

	private class ExitButtonListener implements ActionListener {// create exit button listener
		public void actionPerformed(ActionEvent e) {
			System.exit(0);
		}
	}
}