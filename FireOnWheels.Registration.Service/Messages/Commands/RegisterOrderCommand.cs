using FireOnWheels.Messaging.Commands;

namespace FireOnWheels.Registration.Service.Messages.Commands
{
    //TODO: make it immutable
    public class RegisterOrderCommand : IRegisterOrderCommand
    {
        public string PickupName { get; set; }
        public string PickupAddress { get; set; }
        public string PickupCity { get; set; }
        public string DeliveryName { get; set; }
        public string DeliveryAddress { get; set; }
        public string DeliveryCity { get; set; }
    }
}
