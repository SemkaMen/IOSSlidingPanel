using CoreGraphics;
using UIKit;

namespace iosslidingpanel.CustomControls
{
    public class TransactionOverlayView : UIView
    {
        private readonly CGRect _frame;

        public bool IsOpened { get; private set; }

        public int MarginTop { get; set; }

        public UIView View { get; set; }

        public event ClosedEventHandler OnClosed;
        public delegate void ClosedEventHandler(object sender);

        public event OpenedEventHandler OnOpened;
        public delegate void OpenedEventHandler(object sender);

        public TransactionOverlayView(CGRect frame) : base(frame)
        {
            _frame = frame;

            Frame = new CGRect(frame.Left, frame.Height, frame.Right, 0);
            BackgroundColor = UIColor.Clear;
            Layer.CornerRadius = 7f;
            Alpha = 1f;
            UserInteractionEnabled = true;


            Add(View);

            base.AddGestureRecognizer(new UISwipeGestureRecognizer(Hide)
            {
                ShouldReceiveTouch = (recognizer, touch) =>
                {
                    if (touch.View.IsDescendantOfView(View))
                    {
                        View.ResignFirstResponder();
                        recognizer.CancelsTouchesInView = false;
                        return false;
                    }
                    recognizer.CancelsTouchesInView = true;
                    return true;
                },
                Direction = UISwipeGestureRecognizerDirection.Down
            });
        }

        public void Show()
        {
            if (!IsOpened)
            {
                Animate(0.2, 0.0, UIViewAnimationOptions.CurveLinear, () =>
                {
                    BackgroundColor = UIColor.White;
                    Frame = new CGRect(_frame.Left, _frame.Y + MarginTop, _frame.Width, _frame.Height - MarginTop);
                },
                () =>
                {
                    IsOpened = true;
                    OnOpened(this);
                });
            }
        }

        public void Hide()
        {
            if (IsOpened)
            {
                Animate(0.2, 0.0, UIViewAnimationOptions.CurveLinear, () =>
                {
                    Frame = new CGRect(_frame.Left, _frame.Height, _frame.Width, 0f);
                },
                () =>
                {
                    IsOpened = false;
                    OnClosed(this);
                });
            }
        }

    }
}
