﻿using Apex.System;
using NUnit.Framework;

namespace ApexTest.System
{
    [TestFixture]
    public class DatetimeTests
    {
        [Test]
        public void DatetimeStaticPropertiesAndMethods()
        {
            Assert.DoesNotThrow(() =>
            {
                var now = Datetime.now();
                var notNow = Datetime.newInstance(now.year() + 1, (now.month() + 1) % 12, (now.day() + 1) % 28);

                var then = Datetime.newInstance(1970, 12, 11, 10, 9, 8);
                Assert.AreEqual(1970, then.year());
                Assert.AreEqual(12, then.month());
                Assert.AreEqual(11, then.day());
                Assert.AreEqual(10, then.hour());
                Assert.AreEqual(9, then.minute());
                Assert.AreEqual(8, then.second());

                var parsed = Datetime.parse("1970/12/11");
                Assert.AreEqual(1970, parsed.year());
                Assert.AreEqual(12, parsed.month());
                Assert.AreEqual(11, parsed.day());
            });
        }

        [Test]
        public void DatetimeImplicitConstructionFromDateTime()
        {
            Assert.DoesNotThrow(() =>
            {
                Datetime apexNow = global::System.DateTime.Now;
                global::System.DateTime systemNow = apexNow;
                Datetime anotherApexNow = apexNow;
                Assert.AreEqual(apexNow, anotherApexNow);

                Datetime date1 = new global::System.DateTime(2018, 01, 18, 18, 27, 35);
                Datetime date2 = Datetime.newInstance(2018, 01, 18, 18, 27, 35);
                Assert.AreEqual(date1, date2);
            });
        }

        [Test]
        public void DatetimeInstancePropertiesAndMethods()
        {
            Assert.DoesNotThrow(() =>
            {
                var now = Datetime.now();
                var tomorrow = now.addDays(1);
                Assert.AreNotEqual(now, tomorrow);
                Assert.False(now.isSameDay(tomorrow));

                var nowAgain = Datetime.newInstance(now.date(), now.time());
                Assert.AreEqual(now, nowAgain);

                var hash1 = now.hashCode();
                var hash2 = nowAgain.hashCode();
                Assert.AreEqual(hash1, hash2);

                var prevMonth = now.addMonths(-1);
                Assert.AreNotEqual(now, prevMonth);

                var nextYears = now.addYears(10);
                Assert.AreNotEqual(now, nextYears);

                var prevHours = now.addHours(-3);
                Assert.AreNotEqual(now, prevHours);

                var nextMinutes = now.addMinutes(15);
                Assert.AreNotEqual(now, nextMinutes);

                var prevSeconds = now.addSeconds(-30);
                Assert.AreNotEqual(now, prevSeconds);
                Assert.NotNull(now.toString());
            });
        }
    }
}
