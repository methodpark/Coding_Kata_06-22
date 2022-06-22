package de.methodpark.kata;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

public class AppTest {

	@Test
	public void get42_WhenCalled_Returns42() {
		App app = new App();

		int result = app.get42();

		assertEquals(42, result);
	}
}
