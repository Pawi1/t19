from Post import can_post
import unittest

class TestPosty(unittest.TestCase):
    def test_can_post_ShortMessage_ReturnShortPost(self):
        result = can_post("przykladowa wiadomosc")
        self.assertEqual(result,"short post")
    def test_can_post_LongMessage_ReturnLongPost(self):
        result = can_post("przykladowa wiadomosc która jest troche dłuższa")
        self.assertEqual(result,"long post")
    def test_can_post_InvalidMessage_ReturnInvalidPost(self):
        result = can_post("Lorem ipsum dolor sit amet consectetur adipiscing elit quisque faucibus ex sapien vitae pellentesque sem placerat in id cursus mi pretium tellus duis convallis tempus leo eu aenean sed diam urna tempor pulvinar vivamus fringilla lacus nec metus bibendum egestas.")
        self.assertEqual(result,"invalid post")