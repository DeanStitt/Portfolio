import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

class SpaceshipTest {

	@Test
	void test() {
		Spaceship s = new Spaceship("Rocinante", Location.MARS, Location.BELT, 3);
		assertEquals("[name=Rocinante, current=MARS, destination=BELT, capacity=3, crew=0]", s.toString());

		Traveler t = new Traveler("Rick Ross", Location.MARS);
		s.board(t);
		assertEquals("[name=Rocinante, current=MARS, destination=BELT, capacity=3, crew=1]", s.toString());
		assertFalse(s.board(t));

		Traveler tp = new Traveler("T Pain", Location.EARTH);

		assertFalse(s.board(tp));

		Traveler t1 =  new Traveler("Snoop", Location.MARS);
		s.board(t1);
		Traveler t2 =  new Traveler("Biggie", Location.MARS);
		s.board(t2);
		assertEquals("[name=Rocinante, current=MARS, destination=BELT, capacity=3, crew=3]", s.toString());
		Traveler t3 =  new Traveler("Drake", Location.MARS);
		assertFalse(s.board(t3));
		assertEquals("[name=Rocinante, current=MARS, destination=BELT, capacity=3, crew=3]", s.toString());

		s.move();
		assertEquals("[name=Rocinante, current=BELT, destination=MARS, capacity=3, crew=0]", s.toString());

		assertEquals("[name=Rick Ross, id=1, current=BELT]", t.toString());
	}
}
