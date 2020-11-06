import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

class TravelerTest {

	@Test
	void test() {
		Traveler t = new Traveler("Rick Ross");
		assertEquals("[name=Rick Ross, id=1, current=EARTH]", t.toString());
	}
}
