using System.Collections.Generic;
using GymManager.Entities;

namespace GymManager.Repositories
{
    interface ICardRepository
    {
        IEnumerable<Card> SelectAllCards();

        int GetExpirationDate(Card obj);

        int ChangeCardType(Card obj);

        int ExtendCard(Card obj);

        int GetBalance(Card obj);

        int SetCardActive(Card obj);
    }
}
