using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 每条活动数据
 */
public class ActivityData : IMessageSerialize 
{
	//活动id 
	int _id;	
	//活动排序 
	int _order;	
	// =0 还开始 =1进行中 =2已过时 
	int _state;	
	// =0不刷新 =1刷新并发奖 =2刷新但不发奖 =3刷新但不发奖，手动领奖后可再次领奖
	int _dayRefresh;	
	//活动参数 自己解析
	int _activityType;	
	//活动参数 自己解析
	string _param;	
	//活动描述.活动名自己解析
	string _description;	
	//兑换次数，0-单次，>0 多次兑换
	int _exchangeTime;	
	//登录活动信息
	List<ActivityAwardBean> _awards = new List<ActivityAwardBean>();
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//活动id 
		SerializeUtils.WriteInt(stream, _id);
		//活动排序 
		SerializeUtils.WriteInt(stream, _order);
		// =0 还开始 =1进行中 =2已过时 
		SerializeUtils.WriteInt(stream, _state);
		// =0不刷新 =1刷新并发奖 =2刷新但不发奖 =3刷新但不发奖，手动领奖后可再次领奖
		SerializeUtils.WriteInt(stream, _dayRefresh);
		//活动参数 自己解析
		SerializeUtils.WriteInt(stream, _activityType);
		//活动参数 自己解析
		SerializeUtils.WriteString(stream, _param);
		//活动描述.活动名自己解析
		SerializeUtils.WriteString(stream, _description);
		//兑换次数，0-单次，>0 多次兑换
		SerializeUtils.WriteInt(stream, _exchangeTime);
		//登录活动信息
		SerializeUtils.WriteShort(stream, (short)_awards.Count);

		foreach (var element in _awards)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//活动id 
		_id = SerializeUtils.ReadInt(stream);
		//活动排序 
		_order = SerializeUtils.ReadInt(stream);
		// =0 还开始 =1进行中 =2已过时 
		_state = SerializeUtils.ReadInt(stream);
		// =0不刷新 =1刷新并发奖 =2刷新但不发奖 =3刷新但不发奖，手动领奖后可再次领奖
		_dayRefresh = SerializeUtils.ReadInt(stream);
		//活动参数 自己解析
		_activityType = SerializeUtils.ReadInt(stream);
		//活动参数 自己解析
		_param = SerializeUtils.ReadString(stream);
		//活动描述.活动名自己解析
		_description = SerializeUtils.ReadString(stream);
		//兑换次数，0-单次，>0 多次兑换
		_exchangeTime = SerializeUtils.ReadInt(stream);
		//登录活动信息
		int _awards_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _awards_length; ++i) 
		{
			_awards.Add(SerializeUtils.ReadBean<ActivityAwardBean>(stream));
		}
	}
	
	/**
	 * 活动id 
	 */
	public int Id
	{
		set { _id = value; }
	    get { return _id; }
	}
	
	/**
	 * 活动排序 
	 */
	public int Order
	{
		set { _order = value; }
	    get { return _order; }
	}
	
	/**
	 *  =0 还开始 =1进行中 =2已过时 
	 */
	public int State
	{
		set { _state = value; }
	    get { return _state; }
	}
	
	/**
	 *  =0不刷新 =1刷新并发奖 =2刷新但不发奖 =3刷新但不发奖，手动领奖后可再次领奖
	 */
	public int DayRefresh
	{
		set { _dayRefresh = value; }
	    get { return _dayRefresh; }
	}
	
	/**
	 * 活动参数 自己解析
	 */
	public int ActivityType
	{
		set { _activityType = value; }
	    get { return _activityType; }
	}
	
	/**
	 * 活动参数 自己解析
	 */
	public string Param
	{
		set { _param = value; }
	    get { return _param; }
	}
	
	/**
	 * 活动描述.活动名自己解析
	 */
	public string Description
	{
		set { _description = value; }
	    get { return _description; }
	}
	
	/**
	 * 兑换次数，0-单次，>0 多次兑换
	 */
	public int ExchangeTime
	{
		set { _exchangeTime = value; }
	    get { return _exchangeTime; }
	}
	
	/**
	 * get 登录活动信息
	 * @return 
	 */
	public List<ActivityAwardBean> GetAwards()
	{
		return _awards;
	}
	
	/**
	 * set 登录活动信息
	 */
	public void SetAwards(List<ActivityAwardBean> awards)
	{
		_awards = awards;
	}
	
}